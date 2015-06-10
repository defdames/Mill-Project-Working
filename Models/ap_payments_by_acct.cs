using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_payments_by_acct
    {
        public string ap_payhdr_entid { get; set; }
        public string ap_payhdr_entnm { get; set; }
        public string ap_payhdr_stats { get; set; }
        public Nullable<System.DateTime> ap_payhdr_paydt { get; set; }
        public string gl_acct_key { get; set; }
        public double gl_intface_dbamtcf { get; set; }
        public double gl_intface_cramtcf { get; set; }
        public string gl_cmp_key { get; set; }
        public string po_hdr_key { get; set; }
    }
}
