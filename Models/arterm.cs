using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class arterm
    {
        public string ar_bill_key { get; set; }
        public string ar_terms_key { get; set; }
        public string ar_bill_name { get; set; }
        public string ar_terms_desc { get; set; }
        public Nullable<decimal> ytddaystopay { get; set; }
        public Nullable<int> days { get; set; }
        public Nullable<int> rcount { get; set; }
        public double HIHGBAL { get; set; }
        public Nullable<double> AR_BILL_CLMTC { get; set; }
    }
}
