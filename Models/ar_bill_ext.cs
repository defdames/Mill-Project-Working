using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_bill_ext
    {
        public string gl_cmp_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_bill_rfc { get; set; }
        public int ar_bill_upcnt { get; set; }
        public string ar_bill_xrefcreacct { get; set; }
        public string ar_bill_xrefdebacct { get; set; }
        public string ar_bill_payacct { get; set; }
    }
}
