using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Monitor : Form
    {
        private static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static readonly string ApplicationName = "Google Sheets Integration";
        private static readonly string SpreadsheetId = "1KcxnijTnyoCnTPGa8J1rSdEOip7v23P86Hooyuun0eQ"; // Replace with your Google Sheets ID
        private static readonly string SheetName = "Clients"; // Sheet name should match your database table
        private STM stmForm; // Class-level reference to the STM form
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        private bool isMinimized = false;
        private int seconds = 0;
        private IList<IList<object>> fetchedRows = new List<IList<object>>(); // To store the rows fetched from Google Sheets
        private Dictionary<string, List<string>> clientAssociations = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> processedItems = new Dictionary<string, List<string>>();
        public Monitor()
        {
            InitializeComponent();
            FetchAndSyncGoogleSheetsData();
        }


        private void Monitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbqueueDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.dbqueueDataSet3.Clients);
            // Fetch data from Google Sheets and update the database
            
            ShowSTMOnSecondMonitor();
            //ShowForm1();
        }
        private void ShowForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LoadDataIntoDataGridView()
        {
            bindingList = new BindingList<MonitorClass.MonitorRecord>(monitor.LoadMonitorDGV());
            //List<MonitorClass.MonitorRecord> mon = monitor.LoadMonitorDGV(); 
            DataGridView1.DataSource = bindingList;
        }
        private void ShowSTMOnSecondMonitor()
        {
            if (Screen.AllScreens.Length > 1) // Check if there are multiple monitors
            {
                var secondMonitor = Screen.AllScreens[1]; // Get the second monitor
                if (stmForm == null || stmForm.IsDisposed)
                {
                    stmForm = new STM
                    {
                        StartPosition = FormStartPosition.Manual, // Position manually
                        Location = secondMonitor.WorkingArea.Location // Set location to the second monitor
                    };
                }
                stmForm.Show();
                stmForm.Location = new System.Drawing.Point(
                    secondMonitor.WorkingArea.X + 100, // Offset by 100 pixels
                    secondMonitor.WorkingArea.Y + 100
                );
            }
            else
            {
                MessageBox.Show("Only one monitor detected. STM will open on the primary monitor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (stmForm == null || stmForm.IsDisposed)
                {
                    stmForm = new STM();
                }
                stmForm.Show();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FetchAndSyncGoogleSheetsData()
        {
            try
            {
                // Load Google Sheets credentials
                UserCredential credential;
                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets, // Updated to FromStream
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create the Sheets API service
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define the range of data to fetch
                var range = $"{SheetName}!A2:G1000"; // Adjust range as per your data
                var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

                // Execute the request and fetch data
                var response = request.Execute();
                var values = response.Values;

                if (values != null && values.Count > 0)
                {
                    foreach (var row in values)
                    {
                        UpdateDatabase(row);    
                        this.clientsTableAdapter1.Fill(this.dbqueueDataSet3.Clients);
                        
                    }
                    lblMessage.Text = $"Data synchronized successfully from Google Sheets!";
                    //MessageBox.Show("Data synchronized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    //MessageBox.Show("Data synchronized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    //MessageBox.Show("Data synchronized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found in Google Sheets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Google Sheets data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDatabase(IList<object> row)
        {
            try
            {
                // Skip any row that doesn't have at least 6 columns (index 0-5)
                if (row.Count < 6)
                {
                    MessageBox.Show("Row does not contain enough data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Assuming row[0] is ClientID
                int clientID = Convert.ToInt32(row[0]);

                // Check if the client already exists in the database
                var existingClient = db.Clients.FirstOrDefault(c => c.ClientID == clientID);

                if (existingClient != null)
                {
                    // Update the existing record
                    existingClient.InvoiceNumber = row[1].ToString();
                    existingClient.ClientName = row[2].ToString();
                    existingClient.TransactionDate = DateTime.Parse(row[3].ToString());
                    existingClient.QueuePosition = int.Parse(row[4].ToString());
                    existingClient.RequirementsStatus = row[5].ToString();
                    existingClient.PaymentStatus = row[6].ToString(); // Handle cases if PaymentStatus is missing
                }
                else
                {
                    // Insert a new record
                    var newClient = new Client
                    {
                        ClientID = clientID,
                        InvoiceNumber = row[1].ToString(),
                        ClientName = row[2].ToString(),
                        TransactionDate = DateTime.Parse(row[3].ToString()),
                        QueuePosition = int.Parse(row[4].ToString()),
                            using (var insertCmd = new SqlCommand(query, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ID", row[0]); // Assuming ID is in column A
                                insertCmd.Parameters.AddWithValue("@ClientName", row[1]);
                                insertCmd.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(row[2]));
                                insertCmd.Parameters.AddWithValue("@QueuePosition", int.Parse(row[3].ToString()));
                                insertCmd.Parameters.AddWithValue("@RequirementsStatus", row[4]);
                                insertCmd.Parameters.AddWithValue("@PaymentStatus", row[5]);
                                insertCmd.ExecuteNonQuery();
                                // TODO: This line of code loads data into the 'dbqueueDataSet3.Clients' table. You can move, or remove it, as needed.
                                this.clientsTableAdapter1.Fill(this.dbqueueDataSet3.Clients);

                // Submit the changes to the database
                db.SubmitChanges();
                
                            }
                        }
                    }
                                this.clientsTableAdapter1.Fill(this.dbqueueDataSet3.Clients);
                            }
                        }
                    }
                }

                // Submit the changes to the database
                db.SubmitChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                    string ID = selectedRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString();
                    string clientName = selectedRow.Cells["ClientNameDataGridViewTextBoxColumn"].Value.ToString();
                    string transactionDate = selectedRow.Cells["TransactionDateDataGridViewTextBoxColumn"].Value.ToString();
                    int queuePosition = Convert.ToInt32(selectedRow.Cells["QueuePositionDataGridViewTextBoxColumn"].Value);
                    string requirementsStatus = selectedRow.Cells["RequirementsStatusDataGridViewTextBoxColumn"].Value.ToString();
                    string paymentStatus = selectedRow.Cells["PaymentStatusDataGridViewTextBoxColumn"].Value.ToString();



                    if (paymentStatus == "Unpaid")
                    {
                        MessageBox.Show("not yet paid","Cyrile", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (stmForm != null && !stmForm.IsDisposed)
                        {
                            stmForm.WindowState = FormWindowState.Minimized;
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
                            {
                                Interval = 10 // 1 second delay
                            };

                            // Transfer data after restoring STM
                            stmForm.AddRowToTable(clientName, transactionDate, queuePosition, requirementsStatus, paymentStatus, ID);
                            timer.Tick += (s, args) =>
                            {
                                timer.Stop();
                                stmForm.WindowState = FormWindowState.Maximized;

                            };

                            timer.Start();
                        }
                        else
                        {
                            MessageBox.Show("STM form is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbClients.Items.Add(clientName);
                    }
                    // Add the selected row's dqqata to the STM form
                    


                    
                    // Update the percentage dynamically




                    Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (form1Instance != null)
                    {
                        form1Instance.AddClientToComboBox(queuePosition, clientName);
                    }
                    else
                    {
                        //MessageBox.Show("Form1 is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        {
                            MessageBox.Show("STM form is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbClients.Items.Add(clientName);
                    }
                    // Add the selected row's dqqata to the STM form
                    


                    
                    // Update the percentage dynamically




                    Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (form1Instance != null)
                    {
                        form1Instance.AddClientToComboBox(queuePosition, clientName);
                    }
                    else
                    {
                        //MessageBox.Show("Form1 is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        {
                            MessageBox.Show("STM form is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbClients.Items.Add(clientName);
                    }
                    // Add the selected row's dqqata to the STM form
                    


                    
                    // Update the percentage dynamically




                    Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (form1Instance != null)
                    {
                        form1Instance.AddClientToComboBox(queuePosition, clientName);
                    }
                    else
                    {
                        //MessageBox.Show("Form1 is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    addclienttocombobox( queuePosition,clientName);
                }
                else
                {
                    MessageBox.Show("Please select a row from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    // Ensure a row is selected
            //    if (DataGridView1.SelectedRows.Count > 0)
            //    {
        }
        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedClient)) return;

            // Load unprocessed items into checkedListBox1
            checkedListBox1.Items.Clear();
            if (clientAssociations.ContainsKey(selectedClient))
            {
                foreach (var item in clientAssociations[selectedClient])
                {
                    checkedListBox1.Items.Add(item);
                }
            }

            // Load processed items into checkedListBox2
            checkedListBox2.Items.Clear();
            if (processedItems.ContainsKey(selectedClient))
            {
                foreach (var item in processedItems[selectedClient])
                {
                    checkedListBox2.Items.Add(item);
                }
            }
        }

        private void btnAddToClient_Click(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please select a client before adding items.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newItem = comboBoxItems.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newItem))
            {
                MessageBox.Show("Please select an item to add.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure the client has a list of items in clientAssociations
            if (!clientAssociations.ContainsKey(selectedClient))
            {
                clientAssociations[selectedClient] = new List<string>();
            }
            // Check if the item already exists in the client's list
            if (clientAssociations[selectedClient].Contains(newItem) ||
                (processedItems.ContainsKey(selectedClient) && processedItems[selectedClient].Contains(newItem)))
            {
                MessageBox.Show("This item is already associated with the selected client.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the item to the client's list of unprocessed items
            clientAssociations[selectedClient].Add(newItem);
            checkedListBox1.Items.Add(newItem);

            // Update the percentage dynamically
            UpdateProcessedPercentage();

            MessageBox.Show("Item successfully added to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateProcessedPercentage();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please select a client before processing.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clientAssociations.ContainsKey(selectedClient) || clientAssociations[selectedClient].Count == 0)
            {
                MessageBox.Show("No items are associated with this client to process.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize processed items for the client if not already present
            if (!processedItems.ContainsKey(selectedClient))
            {
                processedItems[selectedClient] = new List<string>();
            }

            // Transfer checked items to processed items
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string itemStr = item.ToString();
                if (!processedItems[selectedClient].Contains(itemStr))
                {
                    checkedListBox2.Items.Add(itemStr);
                    processedItems[selectedClient].Add(itemStr); // Add to processed items
                }
            }

            // Remove processed items from checkedListBox1 and clientAssociations
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                string itemToRemove = checkedListBox1.CheckedItems[i].ToString();
                checkedListBox1.Items.Remove(itemToRemove);
                clientAssociations[selectedClient].Remove(itemToRemove);
            }

            UpdateProcessedPercentage();

            if (stmForm != null && !stmForm.IsDisposed)
            {
                double percentage = (double)processedItems[selectedClient].Count /
                                    (clientAssociations[selectedClient].Count + processedItems[selectedClient].Count) * 100;

                stmForm.UpdateProgressBar(selectedClient, percentage);
            }
            MessageBox.Show("Items successfully processed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSelectAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void radioButtonDeselect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeselect.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void lblPercent_Click(object sender, EventArgs e)
        {

            if (radioButtonSelectAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void radioButtonDeselect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeselect.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void lblPercent_Click(object sender, EventArgs e)
        {

            if (radioButtonSelectAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void radioButtonDeselect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeselect.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void lblPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
