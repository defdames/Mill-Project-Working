using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_terms_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ar_terms_key { get; set; }
        public double ar_terms_dspct { get; set; }
        public int ar_terms_dyavl { get; set; }
        public short ar_terms_dyntd { get; set; }
        public string ar_terms_desc { get; set; }
        public int ar_terms_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime ar_terms_chgdt { get; set; }
        public System.DateTime ar_terms_crtdt { get; set; }
        public short ar_terms_opt { get; set; }
        public int ar_terms_dued { get; set; }
        public short ar_terms_eom { get; set; }
        public int ar_terms_limd { get; set; }
        public short ar_terms_eomdt { get; set; }
        public short ar_terms_graced { get; set; }
    }
}
