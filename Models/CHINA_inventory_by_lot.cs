using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_inventory_by_lot
    {
        public string gl_cmp_Key { get; set; }
        public string in_item_key { get; set; }
        public string packing { get; set; }
        public string in_lot_key { get; set; }
        public double in_lot_qoh { get; set; }
        public string in_locn_key { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> in_whitmpk_scst { get; set; }
        public Nullable<double> totald { get; set; }
        public Nullable<double> ex_rate { get; set; }
        public Nullable<double> sing { get; set; }
        public string in_whs_key { get; set; }
        public string in_whs_name { get; set; }
    }
}
