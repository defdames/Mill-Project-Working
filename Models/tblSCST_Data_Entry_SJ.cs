using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tblSCST_Data_Entry_SJ
    {
        public string in_item_key { get; set; }
        public Nullable<double> C2014_GOLive_Costs { get; set; }
        public string C2014_Purchased_Costs_Notes { get; set; }
        public Nullable<double> C2015_GOLive_Costs { get; set; }
        public string C2015_Purchased_Costs_Notes { get; set; }
        public string uom_key { get; set; }
    }
}
