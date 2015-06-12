using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ASTquickReceiptHistory
    {
        public int historyID { get; set; }
        public string companyKey { get; set; }
        public string branchKey { get; set; }
        public string invoiceKey { get; set; }
        public Nullable<System.DateTime> transactiondate { get; set; }
    }
}
