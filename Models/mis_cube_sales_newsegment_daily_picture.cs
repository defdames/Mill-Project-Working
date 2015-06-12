using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_sales_newsegment_daily_picture
    {
        public string DateSold { get; set; }
        public string Product { get; set; }
        public string ShipKey { get; set; }
        public string Company { get; set; }
        public string PackKey { get; set; }
        public Nullable<double> DollarsSoldLC { get; set; }
        public Nullable<decimal> PoundsSoldLC { get; set; }
        public string Agent { get; set; }
        public string Item { get; set; }
        public string ItemClass { get; set; }
        public Nullable<double> CostValue { get; set; }
        public Nullable<double> KGS { get; set; }
        public Nullable<double> GlobalCost { get; set; }
        public Nullable<double> GlobalMatlValue { get; set; }
        public Nullable<double> GlobalDirectLabor { get; set; }
        public Nullable<double> GlobalVariableCost { get; set; }
        public string ManufacturingLoc { get; set; }
        public string Country { get; set; }
        public string SoldTo { get; set; }
        public string whseacct { get; set; }
        public string CityState { get; set; }
        public string shipname { get; set; }
        public string DomForSam { get; set; }
        public string Ship_Whse { get; set; }
        public string Act_Fcst { get; set; }
        public Nullable<double> MatlValue { get; set; }
        public Nullable<double> RsrcValue { get; set; }
        public string Region { get; set; }
        public Nullable<double> EUROS { get; set; }
        public Nullable<double> DirectLabor { get; set; }
        public Nullable<double> VariableCost { get; set; }
        public Nullable<decimal> FixedCost { get; set; }
        public string ar_bill_key { get; set; }
        public string top_customer_name { get; set; }
        public string market { get; set; }
        public string SALESMGR { get; set; }
    }
}
