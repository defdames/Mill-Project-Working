using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_export_view_op_forecast_vs_actual
    {
        public string company { get; set; }
        public Nullable<int> iyear { get; set; }
        public Nullable<int> imonth { get; set; }
        public string shipkey { get; set; }
        public string location { get; set; }
        public string en_ship_name { get; set; }
        public string product { get; set; }
        public string en_prod_desc { get; set; }
        public string top_customer_name { get; set; }
        public string Salesmgr { get; set; }
        public Nullable<double> actual { get; set; }
        public Nullable<double> forecast { get; set; }
        public Nullable<double> variance { get; set; }
    }
}
