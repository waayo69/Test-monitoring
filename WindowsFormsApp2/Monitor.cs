using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class Monitor : Form
    {
        private static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static readonly string ApplicationName = "Google Sheets Integration";
        private static readonly string SpreadsheetId = "1dCshOpmc9WO-WQR6XV264NgWiOkJR42ZSRYoBocj7sw"; // Replace with your Google Sheets ID
        private static readonly string SheetName = "Clients"; // Sheet name should match your database table
        private STM stmForm; // Class-level reference to the STM form
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        private bool isMinimized = false;
        private int seconds = 0;
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
            ShowForm1();


        }
        private void ShowForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
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
                    }

                    MessageBox.Show("Data synchronized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void updateQue(IList<object> row)
        {
            try
            {
                // Establish a connection to the SQL Server database
                using (var connection = new SqlConnection("Data Source=DESKTOP-TD8UC8F;Initial Catalog=dbqueue;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();

                    // Check if the record exists
                    var query = "SELECT COUNT(*) FROM Que WHERE ID=@ID";
                    using (var checkCmd = new SqlCommand(query, connection))
                    {
                        checkCmd.Parameters.AddWithValue("ID", row[6]); // Assuming ID is in column A
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Skip the existing record
                            return;
                        }
                        else
                        {
                            // Insert new record
                            query = @"
                        INSERT INTO Que (ID, ClientName, Date, Service, PaymentStatus, ID1)
                        VALUES (@ID, @ClientName, @Date, @Service, @PaymentStatus, @ID1)";

                            using (var insertCmd = new SqlCommand(query, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ID", row[0]); // Assuming ID is in column A
                                insertCmd.Parameters.AddWithValue("@ClientName", row[1]);
                                insertCmd.Parameters.AddWithValue("@Date", (row[2]));
                                insertCmd.Parameters.AddWithValue("@Service", row[3]);
                                insertCmd.Parameters.AddWithValue("@PaymentStatus", row[5]);
                                insertCmd.Parameters.AddWithValue("@ID1", row[6]);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDatabase(IList<object> row)
        {
            try
            {
                // Establish a connection to the SQL Server database
                using (var connection = new SqlConnection("Data Source=DESKTOP-TD8UC8F;Initial Catalog=dbqueue;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();

                    // Check if the record exists
                    var query = "SELECT COUNT(*) FROM Clients WHERE ID=@ID";
                    using (var checkCmd = new SqlCommand(query, connection))
                    {
                        checkCmd.Parameters.AddWithValue("ID", row[6]); // Assuming ClientID is in column A
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Skip the existing record
                            return;
                        }
                        else
                        {
                            // Insert new record
                            query = @"
                        INSERT INTO Clients (ID, ClientName, TransactionDate, QueuePosition, RequirementsStatus, PaymentStatus)
                        VALUES (@ID, @ClientName, @TransactionDate, @QueuePosition, @RequirementsStatus, @PaymentStatus)";

                            using (var insertCmd = new SqlCommand(query, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ID", row[0]); // Assuming ID is in column A
                                insertCmd.Parameters.AddWithValue("@ClientName", row[1]);
                                insertCmd.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(row[2]));
                                insertCmd.Parameters.AddWithValue("@QueuePosition", int.Parse(row[3].ToString()));
                                insertCmd.Parameters.AddWithValue("@RequirementsStatus", row[4]);
                                insertCmd.Parameters.AddWithValue("@PaymentStatus", row[5]);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
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
                // Ensure a row is selected
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    // Access the first selected row
                    DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];

                    // Retrieve data from the selected row
                    string ID = selectedRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString();
                    string clientName = selectedRow.Cells["ClientNameDataGridViewTextBoxColumn"].Value.ToString();
                    string transactionDate = selectedRow.Cells["TransactionDateDataGridViewTextBoxColumn"].Value.ToString();
                    int queuePosition = Convert.ToInt32(selectedRow.Cells["QueuePositionDataGridViewTextBoxColumn"].Value);
                    string requirementsStatus = selectedRow.Cells["RequirementsStatusDataGridViewTextBoxColumn"].Value.ToString();
                    string paymentStatus = selectedRow.Cells["PaymentStatusDataGridViewTextBoxColumn"].Value.ToString();

                    // Add the selected row's data to the STM form
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
                    Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (form1Instance != null)
                    {
                        form1Instance.AddClientToComboBox(clientName, queuePosition);
                    }
                    else
                    {
                        MessageBox.Show("Form1 is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAa

            //try
            //{
            //    // Ensure a row is selected
            //    if (DataGridView1.SelectedRows.Count > 0)
            //    {
            //        // Access the first selected row
            //        DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];

            //        // Retrieve data from the selected row

            //        //int ID = selectedRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString();
            //        int ID= Convert.ToInt32(selectedRow.Cells["IDDataGridViewTextBoxColumn"].Value);
            //        string clientName = selectedRow.Cells["ClientNameDataGridViewTextBoxColumn"].Value.ToString();
            //        string Date = selectedRow.Cells["TransactionDateDataGridViewTextBoxColumn"].Value.ToString();
            //        string Status = selectedRow.Cells["RequirementsStatusDataGridViewTextBoxColumn"].Value.ToString();
            //        string paymentStatus = selectedRow.Cells["PaymentStatusDataGridViewTextBoxColumn"].Value.ToString();

            //        // Add the selected row's data to the STM form
            //        if (stmForm != null && !stmForm.IsDisposed)
            //        {

            //            stmForm.QueHere(clientName, Date, Status, paymentStatus, ID);
                        
            //        }
            //        else
            //        {
            //            MessageBox.Show("STM form is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a row from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FetchAndSyncGoogleSheetsData();
        }

        private void TM_Tick(object sender, EventArgs e)
        {
            if (seconds >= 20)
            {
                
                TM.Enabled = false;
                seconds = 0;
                lblTimer.ResetText();
                TM.Enabled = true;
                FetchAndSyncGoogleSheetsData();
            }
            else
            {
                lblTimer.Text = $"Time Elapsed: {seconds++} seconds";
            }
            
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
