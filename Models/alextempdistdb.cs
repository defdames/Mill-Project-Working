using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class alextempdistdb
    {
        public string Company { get; set; }
        public string TranDate { get; set; }
        public string Agent { get; set; }
        public string Grade { get; set; }
        public string ShiptoName { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string SalesType { get; set; }
        public string CustomerWhse { get; set; }
        public Nullable<double> Dollars { get; set; }
        public Nullable<double> Pounds { get; set; }
        public Nullable<decimal> KGS { get; set; }
        public Nullable<double> CostValue { get; set; }
    }
}
