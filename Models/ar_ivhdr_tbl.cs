using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_ivhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string ar_ivhdr_type { get; set; }
        public string ar_ivhdr_stats { get; set; }
        public string en_cust_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_ship_key { get; set; }
        public double ar_ivhdr_ivblc { get; set; }
        public double ar_ivhdr_ivblcf { get; set; }
        public double ar_ivhdr_cshc { get; set; }
        public double ar_ivhdr_cshcf { get; set; }
        public double ar_ivhdr_cdisc { get; set; }
        public double ar_ivhdr_cdiscf { get; set; }
        public double ar_ivhdr_dsalc { get; set; }
        public double ar_ivhdr_dsalcf { get; set; }
        public double ar_ivhdr_dsalcrc { get; set; }
        public double ar_ivhdr_dsalcrcf { get; set; }
        public double ar_ivhdr_wroffc { get; set; }
        public double ar_ivhdr_wroffcf { get; set; }
        public double ar_ivhdr_dbmoc { get; set; }
        public double ar_ivhdr_dbmocf { get; set; }
        public double ar_ivhdr_crmoc { get; set; }
        public double ar_ivhdr_crmocf { get; set; }
        public string gl_crncy_key { get; set; }
        public double ar_ivhdr_rate { get; set; }
        public double ar_ivhdr_origto3 { get; set; }
        public double ar_ivhdr_tobase { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_asofdt { get; set; }
        public System.DateTime tran_date_key { get; set; }
        public System.DateTime ar_ivhdr_duedt { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_stdte { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_prtdt { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_reprntdt { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_wofdt { get; set; }
        public string ar_note_notes { get; set; }
        public string ar_terms_key { get; set; }
        public string ar_reas_key { get; set; }
        public int im_localgrp_key { get; set; }
        public string gl_paycd_key { get; set; }
        public string gl_doccd_key { get; set; }
        public string gl_bkcd_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public short ar_ivhdr_declp { get; set; }
        public int ar_ivhdr_dunflag { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_lastdundt { get; set; }
        public int ar_dunlev_key { get; set; }
        public short ar_ivhdr_eustatf { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_eustdt { get; set; }
        public short ar_ivhdr_eslf { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_esldt { get; set; }
        public string en_eslcatgry_key { get; set; }
        public string ar_bill_exsus { get; set; }
        public short ar_bill_type { get; set; }
        public short ar_ivhdr_mschtyp { get; set; }
        public string so_hdr_key { get; set; }
        public string so_hdr_cpono { get; set; }
        public string so_hdr_porelease { get; set; }
        public Nullable<System.DateTime> so_hdr_crtdt { get; set; }
        public string so_agnt_key { get; set; }
        public string en_frgt_key { get; set; }
        public string en_mode_key { get; set; }
        public string sa_uid_key { get; set; }
        public System.DateTime ar_ivhdr_crtdt { get; set; }
        public System.DateTime ar_ivhdr_chgdt { get; set; }
        public int ar_ivhdr_upcnt { get; set; }
        public string ar_ivdelcd_key { get; set; }
        public Nullable<int> ar_ivhdr_vatmthd { get; set; }
        public double ar_ivhdr_deductcf { get; set; }
        public Nullable<int> ar_bill_adkey { get; set; }
        public Nullable<int> ar_ship_adkey { get; set; }
        public string ar_ivhdr_remk { get; set; }
        public string ar_sat_key { get; set; }
    }
}
