using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class STM : Form
    {
        public STM(/*int clientID, string clientName, string transactionDate, int queuePosition, string requirementsStatus, string paymentStatus*/)
        {
            InitializeComponent();

            //// Set the labels with the passed data
            //lblClientID.Text = clientID.ToString();
            //lblClientName.Text = clientName;
            //lblTransactionDate.Text = transactionDate;
            //lblQueuePosition.Text = queuePosition.ToString();
            //lblRequirementsStatus.Text = requirementsStatus;
            //lblPaymentStatus.Text = paymentStatus;

            //UpdateLabels(clientID, clientName, transactionDate, queuePosition, requirementsStatus, paymentStatus);
        }

        public void AddRowToTable(int clientID, string clientName, string transactionDate, int queuePosition, string requirementsStatus, string paymentStatus, string ID)
        {
            // Define row index
            int rowIndex = tableLayoutPanel1.RowCount;

            // Increase the row count
            tableLayoutPanel1.RowCount += 1;

            // Set the new row style
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add controls (e.g., Labels) for each data point
            tableLayoutPanel1.Controls.Add(new Label { Text = ID.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, rowIndex);
            //tableLayoutPanel1.Controls.Add(new Label { Text = clientID.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = clientName, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = transactionDate, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label { Text = queuePosition.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, rowIndex);
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
            tableLayoutPanel1.Controls.Add(new ProgressBar { Value = 30, Maximum = 100, Dock = DockStyle.Fill, AutoSize = true,Style=ProgressBarStyle.Continuous }, 6, rowIndex);
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
