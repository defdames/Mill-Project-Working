using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tmp_open_orders_20120909
    {
        public Nullable<int> yearcapture { get; set; }
        public Nullable<int> weekcapture { get; set; }
        public Nullable<int> monthcapture { get; set; }
        public string OrderNo { get; set; }
        public string COUNTRY { get; set; }
        public double OrderQty { get; set; }
        public double ShipQty { get; set; }
        public double Price { get; set; }
        public double AllocQty { get; set; }
        public string Status { get; set; }
        public string Product { get; set; }
        public string PONumber { get; set; }
        public System.DateTime ScheduledShipDate { get; set; }
        public System.DateTime PromiseDate { get; set; }
        public System.DateTime RequiredDate { get; set; }
        public string Uom { get; set; }
        public Nullable<double> Packsize { get; set; }
        public string Warehouse { get; set; }
        public string Ship_Key { get; set; }
        public string GL_CMP_KEY { get; set; }
        public string en_ship_name { get; set; }
        public System.DateTime OrderDate { get; set; }
        public short so_dtl_key { get; set; }
        public string en_mktseg_key { get; set; }
        public string Market { get; set; }
        public string Source { get; set; }
        public string SalesType { get; set; }
        public System.DateTime LineCreateDate { get; set; }
    }
}
