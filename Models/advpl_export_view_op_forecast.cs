using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_export_view_op_forecast
    {
        public int iyear { get; set; }
        public int imonth { get; set; }
        public string product { get; set; }
        public string en_ship_key { get; set; }
        public string company { get; set; }
        public Nullable<decimal> quantity { get; set; }
    }
}
