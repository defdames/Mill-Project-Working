using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class alloc_sum
    {
        public Nullable<double> allocqty { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_lot_key { get; set; }
    }
}
