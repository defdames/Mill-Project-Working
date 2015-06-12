using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_vatrate_tbl
    {
        public string gl_cmp_key { get; set; }
        public short gl_vatcd_id { get; set; }
        public string gl_vatcd_key { get; set; }
        public System.DateTime gl_vatrate_actdt { get; set; }
        public double gl_vatrate_pct { get; set; }
        public System.DateTime gl_vatrate_crtdt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_vatrate_chgdt { get; set; }
        public int gl_vatrate_upcnt { get; set; }
        public double gl_vatrate_whldpct { get; set; }
    }
}
