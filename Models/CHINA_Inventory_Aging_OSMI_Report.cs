using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_Inventory_Aging_OSMI_Report
    {
        public string Classification { get; set; }
        public string in_item_key { get; set; }
        public Nullable<double> in_lot_qoh { get; set; }
        public Nullable<double> in_whitmpk_scst { get; set; }
        public string Grouping { get; set; }
        public string ProdGrp { get; set; }
        public string gl_cmp_key { get; set; }
        public string ItemStatus { get; set; }
        public Nullable<decimal> lb_in_lot_qoh { get; set; }
        public Nullable<double> ExtCost { get; set; }
        public Nullable<decimal> kg_in_lot_qoh { get; set; }
    }
}
