using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_vatcd_tbl
    {
        public string gl_cmp_key { get; set; }
        public short gl_vatcd_id { get; set; }
        public string gl_vatcd_key { get; set; }
        public string gl_vatcd_desc { get; set; }
        public short gl_vatcd_tp { get; set; }
        public short gl_vatcd_qlf { get; set; }
        public double gl_vatcd_recp { get; set; }
        public double gl_vatcd_unrp { get; set; }
        public short gl_vatcd_arap { get; set; }
        public string gl_vatcd_ardec { get; set; }
        public string gl_vatcd_ardeci { get; set; }
        public string gl_vatcd_apdec { get; set; }
        public string gl_vatcd_apdeci { get; set; }
        public string gl_vatcd_appos { get; set; }
        public string gl_vatcd_apposi { get; set; }
        public string gl_vatcd_aprec { get; set; }
        public string gl_vatcd_apreci { get; set; }
        public string gl_vatcd_apunr { get; set; }
        public string gl_vatcd_apunri { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_vatcd_chgdt { get; set; }
        public int gl_vatcd_upcnt { get; set; }
        public System.DateTime gl_vatcd_crtdt { get; set; }
        public int gl_vatcd_whldtaxf { get; set; }
        public string gl_acct_whldtax { get; set; }
    }
}
