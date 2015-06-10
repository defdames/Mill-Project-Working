using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_crncy_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_crncy_key { get; set; }
        public string gl_crncy_desc { get; set; }
        public int gl_crncy_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_crncy_chgdt { get; set; }
        public System.DateTime gl_crncy_crtdt { get; set; }
        public short gl_crncy_curp { get; set; }
        public short gl_crncy_conv { get; set; }
        public short gl_crncy_bpdp { get; set; }
        public string gl_crncy_apgain { get; set; }
        public string gl_crncy_aploss { get; set; }
        public string gl_crncy_argain { get; set; }
        public string gl_crncy_arloss { get; set; }
    }
}
