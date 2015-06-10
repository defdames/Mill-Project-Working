using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_rtdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_rthdr_key { get; set; }
        public short so_rtdtl_key { get; set; }
        public string so_prod_key { get; set; }
        public double so_rtdtl_rmaqty { get; set; }
        public string so_rtdtl_rmauom { get; set; }
        public string so_resn_code { get; set; }
        public short so_rtdtl_stat { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string so_ship_key { get; set; }
        public short so_rtdtl_reasontyp { get; set; }
        public double so_rtdtl_skuqty { get; set; }
        public string so_rtdtl_skuuom { get; set; }
        public Nullable<System.DateTime> so_rtdtl_scheduldt { get; set; }
        public short so_rtdtl_insflag { get; set; }
        public string sa_modified_by { get; set; }
        public System.DateTime so_rtdtl_chgdt { get; set; }
        public string so_rtdtl_whstoretu { get; set; }
        public short so_shpitm_key { get; set; }
        public string in_lot_key { get; set; }
        public string so_dtl_sltyp { get; set; }
        public Nullable<System.DateTime> so_ship_date { get; set; }
        public short so_shiplot_key { get; set; }
        public short so_rtdtl_directfla { get; set; }
        public string so_rtdtl_creditby { get; set; }
        public double so_rtdtl_creditqt { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public double so_rtdtl_crmoamt { get; set; }
        public string so_rtdtl_crreason { get; set; }
        public double so_shiplot_qty { get; set; }
        public int so_rtdtl_upcnt { get; set; }
        public short so_rtdtl_fillattr { get; set; }
        public double so_rtdtl_ctfllqty { get; set; }
        public string en_uom_filluom { get; set; }
        public string gl_cmp_rec { get; set; }
        public string so_brnch_rec { get; set; }
        public Nullable<System.DateTime> so_rtdtl_recdt { get; set; }
        public Nullable<double> so_rtdtl_recskuq { get; set; }
        public string sa_user_recby { get; set; }
        public Nullable<double> so_rtdtl_rtfllqty { get; set; }
        public string so_enduse_key { get; set; }
        public Nullable<double> so_rtdtl_ctaltqty { get; set; }
        public string en_uom_alternate { get; set; }
        public string in_origlot_key { get; set; }
        public Nullable<short> ar_dbcrdtl_key { get; set; }
        public string po_recpt_key { get; set; }
    }
}
