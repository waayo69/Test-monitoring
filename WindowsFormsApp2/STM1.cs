using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{

    public partial class STM1 : Form
    {
        private Dictionary<string, System.Windows.Forms.ProgressBar> clientProgressBars = new Dictionary<string, System.Windows.Forms.ProgressBar>();
        public STM1(/*int clientID, string clientName, string transactionDate, int queuePosition, string requirementsStatus, string paymentStatus*/)
        {
            InitializeComponent();
            FetchDataFromSTMTable();

            //// Set the labels with the passed data
            //lblClientID.Text = clientID.ToString();
            //lblClientName.Text = clientName;
            //lblTransactionDate.Text = transactionDate;
            //lblQueuePosition.Text = queuePosition.ToString();
            //lblRequirementsStatus.Text = requirementsStatus;
            //lblPaymentStatus.Text = paymentStatus;

            //UpdateLabels(clientID, clientName, transactionDate, queuePosition, requirementsStatus, paymentStatus);
        }

        private void FetchDataFromSTMTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=waayo69_Clients;User ID=waayo69_Clients;Password=kris123asd;Encrypt=False; Connection Timeout=30;"))
                {
                    connection.Open();
                    string query = "SELECT * FROM STMTable ORDER BY TransactionDate DESC"; // Fetch all records sorted by date

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int clientID = reader.GetInt32(0);
                                string invoiceNum = reader.GetString(1);
                                string clientName = reader.GetString(2);
                                string transactionDate = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                string requirementsStatus = reader.GetString(4);
                                string paymentStatus = reader.GetString(5);

                                // Add the row to the table
                                AddRowToTable(clientID, invoiceNum, clientName, transactionDate, requirementsStatus, paymentStatus);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AddRowToTable(int clientID, string invoiceNum, string clientName, string transactionDate, string requirementsStatus, string paymentStatus)
        {
            // Define row index
            int rowIndex = tableLayoutPanel1.RowCount;

            // Increase the row countqq
            tableLayoutPanel1.RowCount += 1;

            // Set the new row style
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add controls (e.g., Labels) for each data point
            tableLayoutPanel1.Controls.Add(new Label { Text = clientID.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = invoiceNum.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = clientName, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = transactionDate, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, rowIndex);
            Label requirementsLabel = new Label
            {
                Text = requirementsStatus,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                BackColor = requirementsStatus == "PQRF" ? Color.Orange : requirementsStatus == "MPORF" ? Color.Pink : Color.Transparent
                
            };
            
            tableLayoutPanel1.Controls.Add(requirementsLabel, 4, rowIndex);
            Label paymentLabel = new Label
            {
                Text = paymentStatus,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                BackColor = paymentStatus == "Paid" ? Color.Green : paymentStatus == "Unpaid" ? Color.IndianRed : Color.Transparent

            };
            tableLayoutPanel1.Controls.Add(paymentLabel , 5, rowIndex);
            // Add a ProgressBar to the TableLayoutPanel
            var progressBar = new System.Windows.Forms.ProgressBar
            {
                Value = 0,
                Maximum = 100,
                Dock = DockStyle.Fill,
                Style = ProgressBarStyle.Continuous
            };
            tableLayoutPanel1.Controls.Add(progressBar, 6, rowIndex);

            // Map the progress bar to the client name
            clientProgressBars[clientName] = progressBar;

            
        }

        public void UpdateProgressBar(string clientName, double percentage)
        {
            if (clientProgressBars.ContainsKey(clientName) && clientProgressBars[clientName].Enabled)
            {
                System.Windows.Forms.ProgressBar progressBar = clientProgressBars[clientName];
                progressBar.Value = (int)Math.Min(percentage, 100); // Ensure value doesn't exceed 100
            }
        }
        public void UpdateProgressForClient(string clientName)
        {
            // Locate the row with the matching client name
            for (int rowIndex = 0; rowIndex < tableLayoutPanel1.RowCount; rowIndex++)
            {
                var clientNameControl = tableLayoutPanel1.GetControlFromPosition(1, rowIndex);
                if (clientNameControl != null && clientNameControl.Text == clientName)
                {
                    // Find the progress bar in the same row
                    var progressBar = tableLayoutPanel1.GetControlFromPosition(6, rowIndex) as System.Windows.Forms.    ProgressBar;
                    if (progressBar != null)
                    {
                        // Use BackgroundWorker to update the progress bar
                        var backgroundWorker = new BackgroundWorker();
                        backgroundWorker.WorkerReportsProgress = true;

                        backgroundWorker.DoWork += (s, e) =>
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                backgroundWorker.ReportProgress(i);
                                System.Threading.Thread.Sleep(50); // Simulate work
                            }
                        };

                        backgroundWorker.ProgressChanged += (s, e) =>
                        {
                            progressBar.Value = e.ProgressPercentage;
                        };

                        backgroundWorker.RunWorkerAsync();
                        break;
                    }
                }
            }
        }


        //public void UpdateLabels(int clientID, string clientName, string transactionDate, int queuePosition, string requirementsStatus, string paymentStatus)
        //{
        //    lblClientID.Text = $"{clientID}";
        //    lblClientName.Text = $"{clientName}";
        //    lblTransactionDate.Text = $"{transactionDate}";
        //    lblQueuePosition.Text = $"{queuePosition}";
        //    lblRequirementsStatus.Text = $"{requirementsStatus}";
        //    lblPaymentStatus.Text = $"{paymentStatus}";
        //}
        private void STM_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
