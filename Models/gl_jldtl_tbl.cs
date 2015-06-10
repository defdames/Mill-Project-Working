using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_jldtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public int gl_jlnum_key { get; set; }
        public short gl_jldtl_line { get; set; }
        public System.DateTime gl_jlhdr_date { get; set; }
        public string gl_jldtl_desc { get; set; }
        public string gl_acct_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_jldtl_chgdt { get; set; }
        public System.DateTime gl_jldtl_crtdt { get; set; }
        public int gl_jldtl_upcnt { get; set; }
        public string gl_cmp_post { get; set; }
        public double gl_jldtl_cramtc { get; set; }
        public double gl_jldtl_cramtcf { get; set; }
        public double gl_jldtl_dbamtc { get; set; }
        public double gl_jldtl_dbamtcf { get; set; }
    }
}
