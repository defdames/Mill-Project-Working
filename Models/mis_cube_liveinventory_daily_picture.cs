using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_liveinventory_daily_picture
    {
        public Nullable<int> yearcapture { get; set; }
        public Nullable<int> weekcapture { get; set; }
        public Nullable<int> monthcapture { get; set; }
        public string Company { get; set; }
        public string Warehouse { get; set; }
        public string Item { get; set; }
        public string Pack { get; set; }
        public string GLAcct { get; set; }
        public string Lot { get; set; }
        public string Location { get; set; }
        public string ItemSource { get; set; }
        public string Commodity { get; set; }
        public string ABCCode { get; set; }
        public double MinOQ { get; set; }
        public int ROPT { get; set; }
        public double SSTK { get; set; }
        public double COMinOQ { get; set; }
        public int COROPT { get; set; }
        public double COSSTK { get; set; }
        public double NettablePacks { get; set; }
        public double NonNettablePacks { get; set; }
        public double TotalPacks { get; set; }
        public Nullable<decimal> NettableQOHLBS { get; set; }
        public Nullable<decimal> NettableQOHKGS { get; set; }
        public Nullable<decimal> NonNettableQOHLBS { get; set; }
        public Nullable<decimal> NonNettableQOHKGS { get; set; }
        public Nullable<decimal> QOHLBS { get; set; }
        public Nullable<decimal> QOHKGS { get; set; }
        public Nullable<double> QOHGAL { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<double> NettableExtendedPriceBC { get; set; }
        public Nullable<double> NonNettableExtendedPriceBC { get; set; }
        public Nullable<double> QOHExtendedPriceBC { get; set; }
        public double QOHExtendedPriceSING { get; set; }
        public string MfgDate { get; set; }
        public string qc_stats_key { get; set; }
        public double QOHEA { get; set; }
    }
}
