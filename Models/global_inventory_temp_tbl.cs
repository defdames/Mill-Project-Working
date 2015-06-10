using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class global_inventory_temp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string en_prod_key { get; set; }
        public string in_lot_key { get; set; }
        public double inv_qoh { get; set; }
        public string reference_number { get; set; }
        public string uom_key { get; set; }
        public string uom_qty { get; set; }
        public Nullable<System.DateTime> upload_date { get; set; }
    }
}
