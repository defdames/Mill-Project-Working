using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class automated_purchase_receipt_audit
    {
        public string gl_cmp_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_lot_key { get; set; }
        public double in_tran_qty { get; set; }
        public string im_pack_uom { get; set; }
        public string in_tran_demandid { get; set; }
        public string po_recpt_shprf { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public Nullable<System.DateTime> in_tran_date { get; set; }
        public string po_recpt_key { get; set; }
        public string in_desc { get; set; }
        public string xen_prod_key { get; set; }
        public decimal Invoice_Price { get; set; }
        public Nullable<decimal> totald { get; set; }
        public string currency { get; set; }
    }
}
