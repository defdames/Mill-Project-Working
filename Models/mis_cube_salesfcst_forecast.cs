using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_forecast
    {
        public string DateSold { get; set; }
        public string Product { get; set; }
        public string Company { get; set; }
        public Nullable<double> DollarsSoldLC { get; set; }
        public Nullable<double> PoundsSoldLC { get; set; }
        public string Item { get; set; }
        public string ItemClass { get; set; }
        public Nullable<double> CostValue { get; set; }
        public Nullable<decimal> KGS { get; set; }
        public Nullable<double> GlobalCost { get; set; }
        public string DomForSam { get; set; }
        public string Act_Fcst { get; set; }
        public Nullable<double> MatlValue { get; set; }
        public Nullable<int> RsrcValue { get; set; }
        public Nullable<int> EUROS { get; set; }
        public Nullable<double> PriorCostValue { get; set; }
        public Nullable<double> PriorMatlValue { get; set; }
        public string region { get; set; }
        public string market { get; set; }
        public Nullable<double> gl_crcnv_rate { get; set; }
    }
}
