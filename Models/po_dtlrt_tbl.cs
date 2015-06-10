using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_dtlrt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_retrn_key { get; set; }
        public short po_dtl_key { get; set; }
        public short po_dtlrt_repf { get; set; }
        public string po_dtlrt_notes { get; set; }
        public string ap_resn_key { get; set; }
        public string po_hdr_key { get; set; }
        public double po_dtlrt_qty { get; set; }
        public Nullable<double> po_dtlrt_totafill { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
    }
}
