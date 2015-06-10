using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_pick_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_pick_key { get; set; }
        public short in_pick_stats { get; set; }
        public System.DateTime in_pick_entdt { get; set; }
        public Nullable<System.DateTime> in_pick_prtdt { get; set; }
        public Nullable<System.DateTime> in_pick_clsdt { get; set; }
        public int in_pick_upcnt { get; set; }
        public int im_localgrp_key { get; set; }
    }
}
