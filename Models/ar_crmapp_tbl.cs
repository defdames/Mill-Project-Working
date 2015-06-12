using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_crmapp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_dbcrm_key { get; set; }
        public short ar_crmapp_seq { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_crmapp_doccmp { get; set; }
        public string ar_crmapp_docbrnch { get; set; }
        public short ar_crmapp_doctyp { get; set; }
        public string ar_crmapp_doc { get; set; }
        public double ar_crmapp_amtcf { get; set; }
        public double ar_crmapp_amtc { get; set; }
        public string gl_crncy_key { get; set; }
        public int ar_crmapp_upcnt { get; set; }
        public System.DateTime ar_crmapp_crtdt { get; set; }
        public System.DateTime ar_crmapp_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<double> ar_crmapp_discamt { get; set; }
        public double ar_crmapp_wroffc { get; set; }
        public double ar_crmapp_wroffcf { get; set; }
        public double ar_crmapp_docwrofff { get; set; }
        public string ar_crmapp_resn { get; set; }
        public Nullable<double> ar_crmapp_docdisc { get; set; }
        public System.DateTime ar_crmapp_trandt { get; set; }
    }
}
