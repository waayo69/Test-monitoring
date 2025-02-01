using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // Models.cs
    public class ClientData
    {
        public int ClientID { get; set; }
        public string InvoiceNumber { get; set; }
        public string ClientName { get; set; }
        public string TransactionDate { get; set; }
        public string RequirementsStatus { get; set; }
        public string PaymentStatus { get; set; }
        public int Progress { get; set; }
    }

    public class Milestone
    {
        public string ClientName { get; set; }
        public string Description { get; set; }
        public int TargetProgress { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class AppData
    {
        public Dictionary<string, List<string>> ClientAssociations { get; set; }
        public Dictionary<string, List<string>> ProcessedItems { get; set; }
        public Dictionary<string, int> ProgressData { get; set; }
        public List<string> SelectedClients { get; set; }
        public List<ClientData> STMTableData { get; set; }
        public List<Milestone> Milestones { get; set; }
    }
}
