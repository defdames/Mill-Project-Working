using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_hdr_ext
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public string ltd_po_number { get; set; }
        public string o_direct_ship { get; set; }
        public int po_hdr_upcnt { get; set; }
        public Nullable<System.DateTime> po_hdr_shsdt { get; set; }
    }
}
