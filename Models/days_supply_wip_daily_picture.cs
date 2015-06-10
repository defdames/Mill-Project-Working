using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class days_supply_wip_daily_picture
    {
        public Nullable<int> yearcapture { get; set; }
        public Nullable<int> weekcapture { get; set; }
        public Nullable<int> monthcapture { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }
        public double DollarsSoldLC { get; set; }
        public Nullable<decimal> EndInvVol { get; set; }
        public Nullable<decimal> EndInvVal { get; set; }
        public double PoundsSoldLC { get; set; }
        public Nullable<decimal> KGSSoldLC { get; set; }
        public double CostValue { get; set; }
        public Nullable<double> DaysSupplyVolume { get; set; }
        public Nullable<double> DaysSupplyValue { get; set; }
    }
}
