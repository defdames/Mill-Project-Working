using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_reqdt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int po_reqhd_key { get; set; }
        public short po_reqdt_key { get; set; }
        public string im_pack_key { get; set; }
        public string ar_tax_key { get; set; }
        public Nullable<System.DateTime> pa_proj_effdt { get; set; }
        public string pa_proj_key { get; set; }
        public string in_item_key { get; set; }
        public string in_item_desc { get; set; }
        public double po_reqdt_qty { get; set; }
        public string en_vend_key { get; set; }
        public System.DateTime po_reqdt_reqdt { get; set; }
        public string sf_work_key { get; set; }
        public double po_reqdt_issqt { get; set; }
        public Nullable<System.DateTime> po_reqdt_issdt { get; set; }
        public string po_hdr_key { get; set; }
        public short po_dtl_key { get; set; }
        public string pa_atvty_key { get; set; }
        public string gl_acct_key { get; set; }
        public string uom_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string in_buyc_key { get; set; }
        public string ap_remt_key { get; set; }
        public string ap_delfm_key { get; set; }
        public string in_whs_key { get; set; }
        public short po_reqdt_nonstk { get; set; }
        public string po_nstk_key { get; set; }
        public short po_reqdt_specf { get; set; }
        public Nullable<System.DateTime> po_reqdt_reldt { get; set; }
        public double po_reqdt_tgtpr { get; set; }
        public string po_reqdt_crncy { get; set; }
        public string po_reqdt_tgtuom { get; set; }
        public short po_reqdt_taxf { get; set; }
        public int po_reqdt_upcnt { get; set; }
        public System.DateTime po_reqdt_crtdt { get; set; }
        public Nullable<int> po_reqdt_stat { get; set; }
        public int po_reqdt_apprstatus { get; set; }
        public System.DateTime po_reqdt_chgdt { get; set; }
        public string po_reqdt_externalref { get; set; }
        public Nullable<System.DateTime> po_reqdt_clsdt { get; set; }
        public string po_reqdt_errorlog { get; set; }
        public string sa_user_key { get; set; }
        public string en_cstcnt_key { get; set; }
        public string en_frgt_key { get; set; }
        public string en_fob_key { get; set; }
    }
}
