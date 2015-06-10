using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_bkrecdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ap_bank_key { get; set; }
        public string ap_bank_acctno { get; set; }
        public System.DateTime gl_bkrec_stmtdt { get; set; }
        public string gl_bkrecdtl_chkno { get; set; }
        public string gl_remtbill_key { get; set; }
        public string gl_bkrecdtl_pyrcft { get; set; }
        public double gl_bkrecdtl_chkamt { get; set; }
        public string gl_bkrecdtl_stat { get; set; }
        public int gl_bkrecdtl_upcnt { get; set; }
        public System.DateTime gl_bkrecdtl_date { get; set; }
        public string gl_bkrecdtl_desc { get; set; }
        public string gl_bkrecdtl_type { get; set; }
        public string gl_acct_key { get; set; }
        public string gl_paycd_key { get; set; }
        public double gl_bkrecdtl_ckamtf { get; set; }
        public double gl_bkrecdtl_rate { get; set; }
        public string gl_bkcd_key { get; set; }
        public double gl_bkrecdt_origto3 { get; set; }
        public double gl_bkrecdtl_tobase { get; set; }
        public Nullable<System.DateTime> gl_bkrecdtl_asofdt { get; set; }
    }
}
