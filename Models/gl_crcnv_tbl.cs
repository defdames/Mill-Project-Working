using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_crcnv_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_crncy_from { get; set; }
        public string gl_crncy_to { get; set; }
        public System.DateTime gl_crcnv_date { get; set; }
        public double gl_crcnv_rate { get; set; }
        public string gl_crcnv_desc { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_crcnv_chgdt { get; set; }
        public System.DateTime gl_crcnv_crtdt { get; set; }
        public int gl_crcnv_upcnt { get; set; }
        public double gl_crcnv_fac1 { get; set; }
        public double gl_crcnv_fac2 { get; set; }
        public double gl_crcnv_tolr { get; set; }
    }
}
