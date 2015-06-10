using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_desc_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public short po_dtl_key { get; set; }
        public short po_desc_key { get; set; }
        public string po_desc_text { get; set; }
        public int po_desc_upcnt { get; set; }
    }
}
