using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_forecast_asia
    {
        public string product_code { get; set; }
        public string warehouse_code { get; set; }
        public Nullable<double> adjQuantity { get; set; }
        public Nullable<double> quantity { get; set; }
        public string company { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string class_01 { get; set; }
    }
}
