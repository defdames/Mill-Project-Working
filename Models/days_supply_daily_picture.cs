using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class days_supply_daily_picture
    {
        public Nullable<int> yearcapture { get; set; }
        public Nullable<int> weekcapture { get; set; }
        public Nullable<int> monthcapture { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }
        public double DollarsSoldLC { get; set; }
        public double DollarsSold3MTH { get; set; }
        public Nullable<decimal> EndInvVol { get; set; }
        public Nullable<decimal> EndInvVal { get; set; }
        public decimal PoundsSoldLC { get; set; }
        public Nullable<decimal> KGSSoldLC { get; set; }
        public decimal PoundsSold3MTH { get; set; }
        public Nullable<decimal> KGSSold3MTH { get; set; }
        public double CostValue { get; set; }
        public double CostValue3MTH { get; set; }
        public Nullable<decimal> DaysSupplyVolume { get; set; }
        public Nullable<double> DaysSupplyValue { get; set; }
        public Nullable<decimal> DaysSupplyVolume3Month { get; set; }
        public Nullable<double> DaysSupplyValue3Month { get; set; }
    }
}
