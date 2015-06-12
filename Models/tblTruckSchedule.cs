using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tblTruckSchedule
    {
        public int in_wthdr_key { get; set; }
        public Nullable<System.DateTime> in_wthdr_reqdt { get; set; }
        public string in_wthdr_via { get; set; }
        public string in_item_key { get; set; }
        public string in_wthdr_frwhs { get; set; }
        public string in_wthdr_towhs { get; set; }
        public Nullable<int> in_wtdtl_stat { get; set; }
    }
}
