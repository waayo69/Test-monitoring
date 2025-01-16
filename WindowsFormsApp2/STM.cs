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
        public STM(int clientID, string clientName, string transactionDate, int queuePosition, string requirementsStatus, string paymentStatus)
        {
            InitializeComponent();

            // Set the labels with the passed data
            lblClientID.Text = clientID.ToString();
            lblClientName.Text = clientName;
            lblTransactionDate.Text = transactionDate;
            lblQueuePosition.Text = queuePosition.ToString();
            lblRequirementsStatus.Text = requirementsStatus;
            lblPaymentStatus.Text = paymentStatus;
        }

        private void STM_Load(object sender, EventArgs e)
        {
        }
    }
}
