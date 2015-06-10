using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_daily_picture
    {
        public string DateSold { get; set; }
        public string Product { get; set; }
        public string Company { get; set; }
        public Nullable<double> DollarsSoldLC { get; set; }
        public Nullable<double> PoundsSoldLC { get; set; }
        public string Item { get; set; }
        public string ItemClass { get; set; }
        public Nullable<double> CostValue { get; set; }
        public Nullable<double> KGS { get; set; }
        public Nullable<double> GlobalCost { get; set; }
        public string DomForSam { get; set; }
        public string Act_Fcst { get; set; }
        public Nullable<double> MatlValue { get; set; }
        public Nullable<decimal> RsrcValue { get; set; }
        public Nullable<double> EUROS { get; set; }
        public Nullable<double> PriorCostValue { get; set; }
        public Nullable<double> PriorMatlValue { get; set; }
        public Nullable<double> DirectLabor { get; set; }
        public Nullable<double> VariableCost { get; set; }
        public Nullable<decimal> FixedCost { get; set; }
        public string InterCoRegion { get; set; }
        public string salesmgr { get; set; }
    }
}
