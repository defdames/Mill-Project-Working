using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ASTquickReceiptSetup
    {
        public string receiptCompanyKey { get; set; }
        public string receiptBranchKey { get; set; }
        public string receiptVendorKey { get; set; }
        public string shipCompanyKey { get; set; }
        public string shipCustomerKey { get; set; }
    }
}
