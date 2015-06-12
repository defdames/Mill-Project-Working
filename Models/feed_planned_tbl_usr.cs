using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class feed_planned_tbl_usr
    {
        public short feed_plan_id { get; set; }
        public string feed { get; set; }
        public Nullable<System.DateTime> planned_date { get; set; }
        public Nullable<double> planned_qty { get; set; }
        public Nullable<double> actual_qty { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
        public string request_location { get; set; }
        public string source_location { get; set; }
    }
}
