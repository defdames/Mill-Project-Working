using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_2012_forecast
    {
        public string DateSold { get; set; }
        public string Product { get; set; }
        public string Company { get; set; }
        public Nullable<double> DollarsSoldLC { get; set; }
        public Nullable<double> PoundsSoldLC { get; set; }
        public string Item { get; set; }
        public string ItemClass { get; set; }
        public int CostValue { get; set; }
        public int KGS { get; set; }
        public int GlobalCost { get; set; }
        public string DomForSam { get; set; }
        public string Act_FCST { get; set; }
        public int MatlValue { get; set; }
        public int RsrcValue { get; set; }
        public int EUROS { get; set; }
        public string region { get; set; }
        public string market { get; set; }
    }
}
