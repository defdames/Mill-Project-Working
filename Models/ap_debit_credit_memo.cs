using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_debit_credit_memo
    {
        public string gl_cmp_key { get; set; }
        public string ap_vchr_type { get; set; }
        public string ap_vchr_key { get; set; }
        public string ap_vchr_invno { get; set; }
        public System.DateTime ap_vchr_invdt { get; set; }
        public string ap_vchr_stats { get; set; }
        public string gl_crncy_key { get; set; }
        public double ap_vchr_rate { get; set; }
        public double ap_vchr_chkc { get; set; }
        public double ap_vchr_chkf { get; set; }
        public double ap_vchr_adscc { get; set; }
        public double ap_vchr_nondc { get; set; }
        public double ap_vchr_tdscc { get; set; }
        public System.DateTime ap_vchr_date { get; set; }
        public double ap_vchr_pyamt { get; set; }
        public double ap_vchr_pyamtf { get; set; }
        public System.DateTime ap_vchr_duedt { get; set; }
        public System.DateTime ap_vchr_ldsdt { get; set; }
        public double ap_vchr_dscpc { get; set; }
        public int ap_vchr_dydsa { get; set; }
        public int ap_vchr_ntdue { get; set; }
        public string ap_vchr_remk { get; set; }
        public string ap_vchr_ref { get; set; }
        public string ap_resn_key { get; set; }
        public string ap_remt_key { get; set; }
        public string sa_uid_key { get; set; }
        public double ap_vchr_dtltot { get; set; }
        public double ap_vchr_dtltotf { get; set; }
        public double ap_vchr_slstxamt { get; set; }
        public double ap_vchr_slstxamtf { get; set; }
        public double ap_vchr_usetxamt { get; set; }
        public double ap_vchr_usetxamtf { get; set; }
        public string ap_delfm_key { get; set; }
        public double ap_vchr_amtc { get; set; }
        public double ap_vchr_amtcf { get; set; }
        public string gl_paycd_key { get; set; }
        public double ap_vchr_appamtcf { get; set; }
        public double ap_vchr_appamtc { get; set; }
        public Nullable<int> ap_vcdtl_line { get; set; }
        public string in_item_key { get; set; }
        public string po_recpt_key { get; set; }
        public Nullable<double> ap_vcdtl_iunitc { get; set; }
        public string ap_vcdtl_ref { get; set; }
        public Nullable<double> ap_vcdtl_iunitcf { get; set; }
        public string ap_vcdtl_remk { get; set; }
        public string ap_remt_name { get; set; }
        public string im_adres_name { get; set; }
        public string im_adres_line1 { get; set; }
        public string im_adres_line2 { get; set; }
        public string im_adres_line3 { get; set; }
        public string im_adres_city { get; set; }
        public string im_adres_state { get; set; }
        public string im_adres_cntry { get; set; }
        public string im_adres_pczip { get; set; }
        public string im_adres_tel { get; set; }
        public string im_adres_fax { get; set; }
        public string im_adres_telex { get; set; }
        public string ar_terms_desc { get; set; }
    }
}
