using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_audit
    {
        public string VoucherNo { get; set; }
        public string VendorName { get; set; }
        public string PONo { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public double VoucherAmt { get; set; }
        public Nullable<int> VoucherMo { get; set; }
        public Nullable<int> VoucherYr { get; set; }
    }
}
