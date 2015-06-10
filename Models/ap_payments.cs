using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_payments
    {
        public string ap_payhdr_entid { get; set; }
        public string ap_payhdr_entnm { get; set; }
        public string ap_payhdr_stats { get; set; }
        public Nullable<System.DateTime> ap_payhdr_paydt { get; set; }
        public Nullable<double> amount { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
