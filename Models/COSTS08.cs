using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COSTS08
    {
        public string ACT_FCST { get; set; }
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public int CostYr { get; set; }
        public Nullable<double> Cost { get; set; }
    }
}
