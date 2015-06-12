using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_export_view_planned_vs_actual
    {
        public string gl_cmp_key { get; set; }
        public Nullable<int> pdmo { get; set; }
        public Nullable<int> pdyr { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public double PlannedProduction { get; set; }
        public Nullable<double> ActualProduction { get; set; }
        public Nullable<double> Variance { get; set; }
        public string Products_at_Warehouses_Commodity { get; set; }
    }
}
