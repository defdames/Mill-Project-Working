using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_distdb_daily_picture_newsegment
    {
        public string Company { get; set; }
        public string TranDate { get; set; }
        public string Agent { get; set; }
        public string Grade { get; set; }
        public string ShipToName { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string SalesType { get; set; }
        public string CustomerWhse { get; set; }
        public Nullable<double> Dollars { get; set; }
        public Nullable<double> Pounds { get; set; }
        public Nullable<double> KGS { get; set; }
        public Nullable<double> CostValue { get; set; }
        public string market { get; set; }
        public string act_fcst { get; set; }
        public Nullable<double> pdadollars { get; set; }
    }
}
