using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class archway_open_order_dump
    {
        public string orderno { get; set; }
        public string ponumber { get; set; }
        public string product { get; set; }
        public double packqty { get; set; }
        public Nullable<double> weightqty { get; set; }
        public string uom { get; set; }
        public Nullable<double> extprice { get; set; }
        public System.DateTime promisedate { get; set; }
    }
}
