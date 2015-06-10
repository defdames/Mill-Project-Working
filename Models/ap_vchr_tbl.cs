using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_vchr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ap_vchr_type { get; set; }
        public string ap_vchr_key { get; set; }
        public Nullable<short> ap_vchr_icmemof { get; set; }
        public int ap_vchr_upcnt { get; set; }
        public string en_vend_key { get; set; }
        public int ap_chek_key { get; set; }
        public string po_hdr_key { get; set; }
        public int ap_btch_key { get; set; }
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
        public Nullable<System.DateTime> ap_vchr_pysldt { get; set; }
        public double ap_vchr_pyamt { get; set; }
        public double ap_vchr_pyamtf { get; set; }
        public System.DateTime ap_vchr_duedt { get; set; }
        public System.DateTime ap_vchr_ldsdt { get; set; }
        public double ap_vchr_dscpc { get; set; }
        public int ap_vchr_dydsa { get; set; }
        public int ap_vchr_ntdue { get; set; }
        public string pa_proj_key { get; set; }
        public string ap_vchr_remk { get; set; }
        public string ap_vchr_ref { get; set; }
        public string ap_resn_key { get; set; }
        public string ap_remt_key { get; set; }
        public string prog_nam { get; set; }
        public string sa_uid_key { get; set; }
        public int tty_num { get; set; }
        public int ap_remt_adres { get; set; }
        public string en_whs_key { get; set; }
        public short en_vend_1099f { get; set; }
        public string en_1099_key { get; set; }
        public double ap_vchr_dtltot { get; set; }
        public double ap_vchr_dtltotf { get; set; }
        public double ap_vchr_slstxamt { get; set; }
        public double ap_vchr_slstxamtf { get; set; }
        public double ap_vchr_usetxamt { get; set; }
        public double ap_vchr_usetxamtf { get; set; }
        public string ap_delfm_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public short ap_vchr_declp { get; set; }
        public short ap_vchr_recalc { get; set; }
        public double ap_vchr_origto3 { get; set; }
        public double ap_vchr_tobase { get; set; }
        public Nullable<System.DateTime> ap_vchr_asofdt { get; set; }
        public double ap_vchr_nondcf { get; set; }
        public double ap_vchr_adsccf { get; set; }
        public double ap_vchr_tdsccf { get; set; }
        public double ap_vchr_amtc { get; set; }
        public double ap_vchr_amtcf { get; set; }
        public string gl_paycd_key { get; set; }
        public string gl_doccd_key { get; set; }
        public short ap_vchr_payopt { get; set; }
        public int ap_vchr_dueday { get; set; }
        public short ap_vchr_eomopt { get; set; }
        public int ap_vchr_limday { get; set; }
        public short ap_vchr_ivdtf { get; set; }
        public short ap_vchr_slsovrflg { get; set; }
        public double ap_vchr_slsovramtf { get; set; }
        public double ap_vchr_slsovramt { get; set; }
        public double ap_vchr_appamtcf { get; set; }
        public double ap_vchr_appamtc { get; set; }
        public string ap_remt_exsus { get; set; }
        public short ap_remt_type { get; set; }
        public double ap_vchr_amtonhold { get; set; }
        public double ap_vchr_amtonholdf { get; set; }
        public string en_trnsport_key { get; set; }
        public string en_pofob_key { get; set; }
        public Nullable<System.DateTime> ap_vchr_eustatdt { get; set; }
        public short ap_vchr_eustatf { get; set; }
        public string gl_bkcd_key { get; set; }
        public short ap_vchr_autovchf { get; set; }
        public short ap_vchr_substats { get; set; }
        public short ap_vchr_subtype { get; set; }
        public short ap_vchr_alloctype { get; set; }
        public short ap_vchr_allocappf { get; set; }
        public Nullable<System.DateTime> ap_vchr_rollovrdt { get; set; }
        public Nullable<System.DateTime> ap_vchr_allocappdt { get; set; }
        public Nullable<System.DateTime> ap_vchr_clsdt { get; set; }
        public Nullable<System.DateTime> ap_vchr_crtdt { get; set; }
        public Nullable<System.DateTime> ap_vchr_chgdt { get; set; }
        public string gl_cmp_sales { get; set; }
        public string so_brnch_sales { get; set; }
        public string ap_vchr_typesales { get; set; }
        public string ap_vchr_keysales { get; set; }
        public string gl_cmp_ship { get; set; }
        public string so_brnch_ship { get; set; }
        public string ap_vchr_typeship { get; set; }
        public string ap_vchr_keyship { get; set; }
        public double ap_vchr_whldtxamtf { get; set; }
        public Nullable<double> ap_vchr_whldtxamt { get; set; }
        public string ap_vchr_batchno { get; set; }
        public string ap_vtmplt_key { get; set; }
        public double ap_vchr_wthldamtf { get; set; }
    }
}