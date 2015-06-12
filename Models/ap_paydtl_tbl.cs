using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_paydtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int ap_payhdr_key { get; set; }
        public int ap_paydtl_key { get; set; }
        public string ap_paydtl_docbr { get; set; }
        public string ap_paydtl_docty { get; set; }
        public string ap_paydtl_docno { get; set; }
        public string ap_paydtl_ref { get; set; }
        public double ap_paydtl_eldsamt { get; set; }
        public double ap_paydtl_eldsamtf { get; set; }
        public Nullable<System.DateTime> ap_paydtl_eldsdt { get; set; }
        public double ap_paydtl_amt { get; set; }
        public double ap_paydtl_amtf { get; set; }
        public string ap_paydtl_stats { get; set; }
        public string ap_resn_key { get; set; }
        public string gl_acct_key { get; set; }
        public double ap_vchr_rate { get; set; }
        public double ap_paydtl_rate { get; set; }
        public System.DateTime ap_paydtl_crtdt { get; set; }
        public System.DateTime ap_paydtl_chgdt { get; set; }
        public int ap_paydtl_upcnt { get; set; }
        public double ap_paydtl_origto3 { get; set; }
        public double ap_paydtl_tobase { get; set; }
        public Nullable<System.DateTime> ap_paydtl_asofdt { get; set; }
        public string gl_cmp_doc { get; set; }
        public double ap_paydtl_dcmprate { get; set; }
        public double ap_paydtl_dorigto3 { get; set; }
        public double ap_paydtl_dtobase { get; set; }
        public double ap_paydtl_clmamtf { get; set; }
        public double ap_paydtl_clmamt { get; set; }
        public string ap_paydtl_clmcrncy { get; set; }
        public double ap_paydtl_ctobase { get; set; }
        public double ap_paydtl_ctopay { get; set; }
    }
}
