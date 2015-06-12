using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_pdbal_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_acct_key { get; set; }
        public double gl_pdbal_open { get; set; }
        public double gl_pdbal_dbamtc { get; set; }
        public int gl_pdbal_upcnt { get; set; }
        public int gl_perod_seqno { get; set; }
        public double gl_pdbal_cramtc { get; set; }
    }
}
