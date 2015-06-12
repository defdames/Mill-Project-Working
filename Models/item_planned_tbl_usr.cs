using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class item_planned_tbl_usr
    {
        public decimal item_plan_id { get; set; }
        public string item { get; set; }
        public Nullable<System.DateTime> planned_date { get; set; }
        public Nullable<double> planned_qty { get; set; }
        public Nullable<double> actual_qty { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
        public Nullable<System.DateTime> revised_date { get; set; }
        public string sm_remarks { get; set; }
        public string other_location { get; set; }
        public string revised_qty_msg { get; set; }
        public string revised_date_msg { get; set; }
    }
}
