using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_bgdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_bdgt_id { get; set; }
        public int gl_perod_seqno { get; set; }
        public string gl_acct_key { get; set; }
        public string gl_bgdtl_ref1 { get; set; }
        public string gl_bgdtl_ref2 { get; set; }
        public double gl_bdgt_amt { get; set; }
        public double gl_bdgt_prcnt { get; set; }
        public int gl_bgdtl_upcnt { get; set; }
    }
}
