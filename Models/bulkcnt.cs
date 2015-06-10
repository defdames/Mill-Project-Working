using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bulkcnt
    {
        public string in_item_key { get; set; }
        public string in_whs_key { get; set; }
        public int rcount { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
