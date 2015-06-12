using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_vcdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ap_vchr_type { get; set; }
        public string ap_vchr_key { get; set; }
        public int ap_vcdtl_line { get; set; }
        public int ap_vcdtl_upcnt { get; set; }
        public string in_item_key { get; set; }
        public string po_recpt_key { get; set; }
        public short po_dtl_key { get; set; }
        public double ap_vcdtl_invqt { get; set; }
        public double ap_vcdtl_iunitc { get; set; }
        public double ap_vcdtl_dedt { get; set; }
        public string ap_resn_key { get; set; }
        public string ap_vcdtl_ref { get; set; }
        public int ap_vcdtl_manpy { get; set; }
        public string ap_vcdtl_mnprf { get; set; }
        public double ap_vcdtl_iunitcf { get; set; }
        public string ap_vcdtl_stats { get; set; }
        public string prog_name { get; set; }
        public string sa_uid_key { get; set; }
        public int tty_num { get; set; }
        public string ap_vcdtl_remk { get; set; }
        public string im_pack_key { get; set; }
        public string uom_key { get; set; }
        public short ap_vchr_stock { get; set; }
        public Nullable<short> ap_vcdtl_adjfl { get; set; }
        public string so_load_key { get; set; }
        public string so_ship_key { get; set; }
        public double ap_vcdtl_miscc { get; set; }
        public double ap_vcdtl_misccf { get; set; }
        public short en_vend_1099f { get; set; }
        public string en_1099_key { get; set; }
        public short ap_vcdtl_taxf { get; set; }
        public short ap_vcdtl_slsusef { get; set; }
        public string ar_tax_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public double ap_vcdtl_vatc { get; set; }
        public double ap_vcdtl_vatcf { get; set; }
        public double ap_vcdtl_frtinvc { get; set; }
        public double ap_vcdtl_frtcadjc { get; set; }
        public double ap_vcdtl_othinvc { get; set; }
        public double ap_vcdtl_othcadjc { get; set; }
        public double ap_vcdtl_matinvc { get; set; }
        public double ap_vcdtl_matcadjc { get; set; }
        public double ap_vcdtl_cmpwtqty { get; set; }
        public short ap_vcdtl_morelessf { get; set; }
        public Nullable<System.DateTime> ap_vcdtl_crtdt { get; set; }
        public Nullable<System.DateTime> ap_vcdtl_chgdt { get; set; }
    }
}
