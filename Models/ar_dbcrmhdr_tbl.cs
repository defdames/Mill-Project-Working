using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dbcrmhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public System.DateTime tran_date_key { get; set; }
        public Nullable<System.DateTime> ar_dbcrm_prtdt { get; set; }
        public System.DateTime comp_date_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_dbcrm_stats { get; set; }
        public string sa_uid_key { get; set; }
        public double ar_dbcrm_amt { get; set; }
        public double ar_dbcrm_cramt { get; set; }
        public string ar_dbcrm_remk { get; set; }
        public string ar_dbcrm_ptrmk { get; set; }
        public double ar_dbcrm_rchgc { get; set; }
        public double ar_dbcrm_amtf { get; set; }
        public double ar_dbcrm_cramtf { get; set; }
        public double ar_dbcrm_rchgcf { get; set; }
        public string gl_crncy_key { get; set; }
        public double ar_dbcrmhdr_rate { get; set; }
        public int ar_dbcrmhdr_upcnt { get; set; }
        public double ar_dbcrm_wroffc { get; set; }
        public double ar_dbcrm_wroffcf { get; set; }
        public Nullable<System.DateTime> ar_dbcrmhdr_stdte { get; set; }
        public Nullable<System.DateTime> ar_dbcrmhdr_dundt { get; set; }
        public int ar_dbcrmhdr_dunflg { get; set; }
        public int ar_dunlev_key { get; set; }
        public int im_localgrp_key { get; set; }
        public string gl_doccd_key { get; set; }
        public string gl_paycd_key { get; set; }
        public int en_vatmthd_key { get; set; }
        public double ar_dbcrm_origto3 { get; set; }
        public double ar_dbcrm_tobase { get; set; }
        public Nullable<System.DateTime> ar_dbcrm_asofdt { get; set; }
        public double ar_dbcrmhdr_applcf { get; set; }
        public double ar_dbcrmhdr_applc { get; set; }
        public short ar_dbcrmhdr_crttyp { get; set; }
        public short ar_dbcrmhdr_reftyp { get; set; }
        public string ar_dbcrmhdr_refdoc { get; set; }
        public string ar_dbcrmhdr_auth { get; set; }
        public Nullable<System.DateTime> so_hdr_crtdt { get; set; }
        public string ar_dbcrm_distype { get; set; }
        public short ar_dbcrm_eslf { get; set; }
        public Nullable<System.DateTime> ar_dbcrm_esldt { get; set; }
        public string en_eslcatgry_key { get; set; }
        public string gl_bkcd_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public short ar_bill_type { get; set; }
        public string ar_bill_exsus { get; set; }
        public string ar_terms_key { get; set; }
        public Nullable<System.DateTime> ar_dbcrmhdr_duedt { get; set; }
        public Nullable<double> ar_dbcrm_cdiscf { get; set; }
        public Nullable<double> ar_dbcrm_dsalcf { get; set; }
        public string ar_ship_key { get; set; }
        public Nullable<double> ar_dbcrm_dsalcrcf { get; set; }
        public short ar_dbcrmhdr_mcpof { get; set; }
        public short ar_dbcrmhdr_basis { get; set; }
        public double ar_dbcrm_deductcf { get; set; }
        public string so_hdr_cpono { get; set; }
        public string ar_dbcrmhdr_replacepo { get; set; }
        public string ar_sat_key { get; set; }
    }
}
