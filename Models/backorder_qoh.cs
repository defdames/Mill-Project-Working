using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class backorder_qoh
    {
        public string type { get; set; }
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public Nullable<double> QOH { get; set; }
    }
}
