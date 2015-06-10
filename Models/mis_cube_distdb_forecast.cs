using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_distdb_forecast
    {
        public string company { get; set; }
        public string trandate { get; set; }
        public string agent { get; set; }
        public string Grade { get; set; }
        public string ShipToName { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string SalesType { get; set; }
        public string CustomerWhse { get; set; }
        public Nullable<double> Dollars { get; set; }
        public Nullable<double> Pounds { get; set; }
        public Nullable<decimal> KGS { get; set; }
        public Nullable<double> costvalue { get; set; }
        public string market { get; set; }
        public string act_fcst { get; set; }
    }
}
