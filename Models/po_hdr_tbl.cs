using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_hdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public Nullable<System.DateTime> pa_proj_effdt { get; set; }
        public string pa_proj_key { get; set; }
        public string en_vend_key { get; set; }
        public string in_buyc { get; set; }
        public int po_hdr_typ { get; set; }
        public string in_whs_key { get; set; }
        public Nullable<System.DateTime> po_hdr_clsdt { get; set; }
        public System.DateTime po_hdr_orddt { get; set; }
        public Nullable<System.DateTime> po_hdr_prmdt { get; set; }
        public Nullable<System.DateTime> po_hdr_prtdt { get; set; }
        public System.DateTime po_hdr_reqdt { get; set; }
        public Nullable<System.DateTime> po_hdr_revdt { get; set; }
        public string po_hdr_via { get; set; }
        public string po_hdr_confm { get; set; }
        public int po_hdr_taxf { get; set; }
        public string ar_terms_key { get; set; }
        public string po_hdr_remks { get; set; }
        public int po_hdr_revno { get; set; }
        public int po_hdr_hldcd { get; set; }
        public int po_hdr_stats { get; set; }
        public string gl_crncy_key { get; set; }
        public double po_hdr_rate { get; set; }
        public string so_hdr_key { get; set; }
        public int po_hdr_upcnt { get; set; }
        public int po_hdr_prtfl { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime po_hdr_chgdt { get; set; }
        public System.DateTime po_hdr_crtdt { get; set; }
        public string en_carr_key { get; set; }
        public string en_service_key { get; set; }
        public Nullable<System.DateTime> po_hdr_cnfdt { get; set; }
        public int po_hdr_dyely { get; set; }
        public string po_resn_key { get; set; }
        public string ap_remt_key { get; set; }
        public string po_hdr_cnfvia { get; set; }
        public string pa_atvty_key { get; set; }
        public string ar_tax_key { get; set; }
        public string sf_plant_key { get; set; }
        public int ap_remt_adkey { get; set; }
        public string ap_delfm_key { get; set; }
        public int ap_delfm_adkey { get; set; }
        public Nullable<System.DateTime> po_hdr_reldt { get; set; }
        public int im_adres_vend { get; set; }
        public int im_adres_whs { get; set; }
        public short po_hdr_sendf { get; set; }
        public Nullable<System.DateTime> po_hdr_ordstatdt { get; set; }
        public double po_hdr_origto3 { get; set; }
        public double po_hdr_tobase { get; set; }
        public Nullable<System.DateTime> po_hdr_asofdt { get; set; }
        public string gl_vatcd_key { get; set; }
        public short po_hdr_type { get; set; }
        public short po_hdr_declp { get; set; }
        public short po_hdr_incl { get; set; }
        public short po_hdr_eustatf { get; set; }
        public Nullable<System.DateTime> po_hdr_eustatdt { get; set; }
        public string en_fob_key { get; set; }
        public string en_trnsport_key { get; set; }
        public string gl_cmp_sales { get; set; }
        public string so_brnch_sales { get; set; }
        public string po_hdr_exsus { get; set; }
        public int po_hdr_copyf { get; set; }
        public int po_hdr_autovchf { get; set; }
        public int im_localgrp_key { get; set; }
        public string so_hdr_sales { get; set; }
        public string po_template_key { get; set; }
        public string po_hdr_copyfrom { get; set; }
        public string en_frgt_key { get; set; }
        public int po_hdr_frtf { get; set; }
        public string en_cstcnt_key { get; set; }
        public int po_hdr_sendasnf { get; set; }
        public string en_mode_key { get; set; }
        public int po_hdr_fixedratef { get; set; }
        public int po_hdr_shipfullf { get; set; }
        public int po_hdr_ovrminlmtf { get; set; }
        public string sa_created_by { get; set; }
        public virtual sa_user_tbl sa_user_tbl { get; set; }
    }
}
