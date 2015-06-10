using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_reqds_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int po_reqhd_key { get; set; }
        public short po_reqdt_key { get; set; }
        public short po_reqds_key { get; set; }
        public string po_reqds_text { get; set; }
    }
}
