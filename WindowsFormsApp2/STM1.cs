using Newtonsoft.Json;
using System;
using System.IO;
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
        private List<string> selectedClients = new List<string>(); // Track selected clients
        private List<ClientData> allClients = new List<ClientData>();
        public STM1()
        {
            InitializeComponent();
            FetchDataFromSTMTable();
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
                                AddRowToTable(clientID, invoiceNum, clientName, transactionDate, requirementsStatus, paymentStatus, "Planning");
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
        public void AddRowToTable(int clientID, string invoiceNum, string clientName, string transactionDate, string requirementsStatus, string paymentStatus, string field="Planning")
        {

            // Define row index
            int rowIndex = tableLayoutPanel1.RowCount;

            // Increase the row count
            tableLayoutPanel1.RowCount += 1;

            // Set the new row style
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add controls (e.g., Labels) for each data point
            tableLayoutPanel1.Controls.Add(new Label { Text = invoiceNum.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = clientName, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = transactionDate, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = clientID.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, rowIndex);
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


            Label fieldLabel = new Label
            {
                Text = field,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                BackColor = field == "Liaison" ? Color.Pink : Color.Transparent // Customize background color based on field value
            };
            tableLayoutPanel1.Controls.Add(fieldLabel, 7, rowIndex);


            //tableLayoutPanel1.Controls.Add(new Label { Text = field.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 7, rowIndex);
            // Map the progress bar to the client name
            clientProgressBars[clientName] = progressBar;

            // Add client to selectedClients list if not already present
            if (!selectedClients.Contains(clientName))
            {
                selectedClients.Add(clientName);
            }

        }

        public void newField(string clientName, string newFieldValue)
        {
            // Find the row index for the client
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                var clientNameLabel = tableLayoutPanel1.GetControlFromPosition(1, i) as Label;
                if (clientNameLabel != null && clientNameLabel.Text == clientName)
                {
                    // Update the field in the 7th column
                    var fieldLabel = tableLayoutPanel1.GetControlFromPosition(7, i) as Label;
                    if (fieldLabel != null)
                    {
                        fieldLabel.Text = newFieldValue;
                        fieldLabel.BackColor = newFieldValue == "Liaison" ? Color.Pink : Color.Transparent; // Customize background color
                    }
                    break;
                }
            }
        }


        public void UpdateProgressBar(string clientName, double percentage)
        {
            if (clientProgressBars.ContainsKey(clientName) && clientProgressBars[clientName].Enabled)
            {
                System.Windows.Forms.ProgressBar progressBar = clientProgressBars[clientName];
                progressBar.Value = (int)Math.Min(percentage, 100); // Ensure value doesn't exceed 100
            }
        }

        private void STM_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
