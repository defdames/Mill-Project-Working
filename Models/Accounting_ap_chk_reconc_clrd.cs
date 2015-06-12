using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Accounting_ap_chk_reconc_clrd
    {
        public string Chk_num { get; set; }
        public Nullable<System.DateTime> Chk_dte { get; set; }
        public string Ven_num { get; set; }
        public string Ven_nam { get; set; }
        public double Chk_amt { get; set; }
        public string Clrd_outst { get; set; }
        public Nullable<System.DateTime> Dat_Clrd { get; set; }
        public string ap_payhdr_stats { get; set; }
        public string gl_cmp_key { get; set; }
        public string Bank { get; set; }
    }
}
