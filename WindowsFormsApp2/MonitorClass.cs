using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class MonitorClass
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public class MonitorRecord
        {
            public int ClientID { get; set; }
            public string InvoiceNumber { get; set; }
            public string ClientName { get; set; }
            public DateTime? TransactionDate { get; set; }
            public int? QueuePosition { get; set; }
            public string RequirementsStatus { get; set; }
            public string PaymentStatus { get; set; }
        }
        public class STMPanels
        {
            public int? ClientID { get; set; }
            public string InvoiceNumber { get; set; }
            public string ClientName { get; set; }
            public string TransactionDate { get; set; }
            public string RequirementsStatus { get; set; }
            public string PaymentStatus { get; set; }
        }
        public List<MonitorRecord> LoadMonitorDGV()
        {
            var mon = (from e in db.Clients
                       select new MonitorRecord
                       {
                           ClientID = e.ClientID,
                           InvoiceNumber = e.InvoiceNumber,
                           ClientName = e.ClientName,
                           TransactionDate = e.TransactionDate,
                           QueuePosition = e.QueuePosition,
                           RequirementsStatus = e.RequirementsStatus,
                           PaymentStatus = e.PaymentStatus
                       }).ToList();
            return mon;
        }
        public List<STMPanels> LoadSTMPanel()
        {
            var stm = (from e in db.STMTables
                       select new STMPanels
                       {
                           ClientID = e.ClientID,
                           InvoiceNumber = e.InvoiceNumber,
                           ClientName = e.ClientName,
                           TransactionDate = e.TransactionDate,
                           RequirementsStatus = e.RequirementsStatus,
                           PaymentStatus = e.PaymentStatus
                       }).ToList();

            return stm;
        }

    }
}
