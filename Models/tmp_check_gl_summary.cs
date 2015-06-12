using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tmp_check_gl_summary
    {
        public string gl_acct_key { get; set; }
        public string gl_acct_desc { get; set; }
        public Nullable<double> check_amount { get; set; }
        public string ap_vchr_key { get; set; }
        public Nullable<double> varianceamt { get; set; }
        public Nullable<double> po_dtlrc_qty { get; set; }
        public Nullable<double> ap_vcdtl_invqt { get; set; }
        public string sectionpart { get; set; }
        public Nullable<double> ap_vchr_tdscc { get; set; }
        public Nullable<int> ap_vcdtl_line { get; set; }
        public Nullable<double> net_amt { get; set; }
        public string Chk_num { get; set; }
    }
}
