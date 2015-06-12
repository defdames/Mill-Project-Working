using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class item_demand_tbl_usr
    {
        public string item { get; set; }
        public Nullable<double> onhand_qty { get; set; }
        public Nullable<double> demand { get; set; }
        public Nullable<double> excess_demand { get; set; }
        public Nullable<short> Review { get; set; }
        public Nullable<short> Reviewed { get; set; }
        public Nullable<System.DateTime> DateTime_Stamp { get; set; }
        public string Source_Location { get; set; }
        public Nullable<double> FreeStock { get; set; }
        public Nullable<double> Alcqt { get; set; }
    }
}
