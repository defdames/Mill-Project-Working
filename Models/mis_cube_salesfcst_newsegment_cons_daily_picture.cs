using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_newsegment_cons_daily_picture
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
        public Nullable<double> RsrcValue { get; set; }
        public Nullable<int> EUROS { get; set; }
        public Nullable<double> PriorCostValue { get; set; }
        public Nullable<double> PriorMatlValue { get; set; }
        public Nullable<double> DirectLabor { get; set; }
        public Nullable<double> VariableCost { get; set; }
        public Nullable<double> FixedCost { get; set; }
        public string InterCoRegion { get; set; }
        public string market { get; set; }
        public string salesmgr { get; set; }
    }
}
