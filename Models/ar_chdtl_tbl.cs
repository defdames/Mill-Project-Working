using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_chdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_chek_key { get; set; }
        public int ar_chdtl_key { get; set; }
        public string ar_chdtl_doccmp { get; set; }
        public string ar_chdtl_docbrnch { get; set; }
        public string ar_chdtl_doctype { get; set; }
        public string ar_chdtl_dockey { get; set; }
        public System.DateTime ar_chdtl_trandt { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_chdtl_resn { get; set; }
        public double ar_chdtl_appamt { get; set; }
        public double ar_chdtl_appamtf { get; set; }
        public double ar_chdtl_docamtf { get; set; }
        public double ar_chdtl_disamt { get; set; }
        public double ar_chdtl_disamtf { get; set; }
        public double ar_chdtl_docdisf { get; set; }
        public double ar_chdtl_wroffc { get; set; }
        public double ar_chdtl_wroffcf { get; set; }
        public double ar_chdtl_docwrofff { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime ar_chdtl_crtdt { get; set; }
        public System.DateTime ar_chdtl_chgdt { get; set; }
        public int ar_chdtl_upcnt { get; set; }
    }
}
