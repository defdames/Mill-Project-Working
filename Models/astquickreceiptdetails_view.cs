using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class astquickreceiptdetails_view
    {
        public string ar_ivhdr_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_gl_cmp_key { get; set; }
        public string ar_ship_key { get; set; }
        public string so_hdr_key { get; set; }
        public string so_cpono { get; set; }
        public short so_dtl_key { get; set; }
        public string so_prod_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_prod_uom { get; set; }
        public double shippedqty { get; set; }
        public int po_hdr_stats { get; set; }
        public Nullable<System.DateTime> po_hdr_clsdt { get; set; }
        public string po_in_item_key { get; set; }
        public string po_im_pack_key { get; set; }
        public string po_dtl_uom { get; set; }
        public Nullable<double> po_dtl_dueqt { get; set; }
        public Nullable<System.DateTime> po_dtl_clsdt { get; set; }
        public Nullable<short> po_dtl_key { get; set; }
        public string PO_CO { get; set; }
    }
}
