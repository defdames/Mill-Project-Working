using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_vatreg_tbl
    {
        public string gl_cmp_key { get; set; }
        public short gl_vatreg_ent { get; set; }
        public string gl_vatreg_key { get; set; }
        public string en_cntry_key { get; set; }
        public string gl_vatreg_num { get; set; }
        public string gl_vatcd_key { get; set; }
        public System.DateTime gl_vatreg_crtdt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_vatreg_chgdt { get; set; }
        public int gl_vatreg_upcnt { get; set; }
    }
}
