using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bm_excess_inventory_summary
    {
        public string in_item_key { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
        public Nullable<double> OnHand { get; set; }
    }
}
