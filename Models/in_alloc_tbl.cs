using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_alloc_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_alloc_entid { get; set; }
        public string in_alloc_ordtp { get; set; }
        public string gl_cmp_demand { get; set; }
        public string in_alloc_ordid { get; set; }
        public short in_alloc_line { get; set; }
        public double in_alloc_qty { get; set; }
        public string im_pack_key { get; set; }
        public int in_alloc_upcnt { get; set; }
    }
}
