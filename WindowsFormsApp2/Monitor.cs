using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Monitor : Form
    {
        private static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static readonly string ApplicationName = "Google Sheets Integration";
        private static readonly string SpreadsheetId = "1dCshOpmc9WO-WQR6XV264NgWiOkJR42ZSRYoBocj7sw"; // Replace with your Google Sheets ID
        private static readonly string SheetName = "Clients"; // Sheet name should match your database table

        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbqueueDataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dbqueueDataSet2.Clients);
            // TODO: This line of code loads data into the 'dbqueueKani.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dbqueueDataSet2.Clients);
            // TODO: This line of code loads data into the 'dbqueueDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dbqueueDataSet2.Clients);
            // Fetch data from Google Sheets and update the database
            FetchAndSyncGoogleSheetsData();

            // Load data into the DataGridView from the database
            this.clientsTableAdapter.Fill(this.dbqueueDataSet2.Clients);
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
                var range = $"{SheetName}!A2:F1000"; // Adjust range as per your data
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

        private void UpdateDatabase(IList<object> row)
        {
            try
            {
                // Establish a connection to the SQL Server database
                using (var connection = new SqlConnection("Data Source=DESKTOP-TD8UC8F;Initial Catalog=dbqueue;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();

                    // Check if the record exists
                    var query = "SELECT COUNT(*) FROM Clients WHERE ClientID = @ClientID";
                    using (var checkCmd = new SqlCommand(query, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ClientID", row[0]); // Assuming ClientID is in column A
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update existing record
                            query = @"
                                UPDATE Clients
                                SET ClientName = @ClientName,
                                    TransactionDate = @TransactionDate,
                                    QueuePosition = @QueuePosition,
                                    RequirementsStatus = @RequirementsStatus,
                                    PaymentStatus = @PaymentStatus
                                WHERE ClientID = @ClientID";

                            using (var updateCmd = new SqlCommand(query, connection))
                            {
                                //updateCmd.Parameters.AddWithValue("@InvoiceNumber", row[1]);
                                updateCmd.Parameters.AddWithValue("@ClientName", row[1]);
                                updateCmd.Parameters.AddWithValue("@TransactionDate",(row[2]));
                                updateCmd.Parameters.AddWithValue("@QueuePosition", int.Parse(row[3].ToString()));
                                updateCmd.Parameters.AddWithValue("@RequirementsStatus", row[4]);
                                updateCmd.Parameters.AddWithValue("@PaymentStatus", row[5]);
                                updateCmd.ExecuteNonQuery();
                            } 
                        }
                        else
                        {
                            // Insert new record
                            query = @"
                                INSERT INTO Clients (ClientName, TransactionDate, QueuePosition, RequirementsStatus, PaymentStatus)
                                VALUES (@ClientName, @TransactionDate, @QueuePosition, @RequirementsStatus, @PaymentStatus)";

                            using (var insertCmd = new SqlCommand(query, connection))
                            {
                                //insertCmd.Parameters.AddWithValue("@InvoiceNumber", row[1]);
                                insertCmd.Parameters.AddWithValue("@ClientName", row[1]);
                                insertCmd.Parameters.AddWithValue("@TransactionDate", (row[2]));
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
                    int clientID = Convert.ToInt32(selectedRow.Cells["clientIDDataGridViewTextBoxColumn"].Value);
                    string clientName = selectedRow.Cells["ClientNameDataGridViewTextBoxColumn"].Value.ToString();
                    string transactionDate = selectedRow.Cells["TransactionDateDataGridViewTextBoxColumn"].Value.ToString();
                    int queuePosition = Convert.ToInt32(selectedRow.Cells["QueuePositionDataGridViewTextBoxColumn"].Value);
                    string requirementsStatus = selectedRow.Cells["RequirementsStatusDataGridViewTextBoxColumn"].Value.ToString();
                    string paymentStatus = selectedRow.Cells["PaymentStatusDataGridViewTextBoxColumn"].Value.ToString();

                    // Pass data to the STM form via constructor
                    STM stmForm = new STM(clientID, clientName, transactionDate, queuePosition, requirementsStatus, paymentStatus);

                    // Show the STM form
                    stmForm.Show();
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
        }

    }
}
