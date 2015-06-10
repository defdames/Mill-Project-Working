using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class aged_material4
    {
        public string ItemKey { get; set; }
        public string PackKey { get; set; }
        public string LotKey { get; set; }
        public string Whse { get; set; }
        public string Loc { get; set; }
        public double QoH { get; set; }
        public Nullable<double> ExtAmt { get; set; }
        public Nullable<double> ExtAmtLb { get; set; }
        public string Commodity { get; set; }
        public string ItemDes { get; set; }
        public string ABCCode { get; set; }
        public string UoM { get; set; }
        public string ClassKey { get; set; }
        public Nullable<System.DateTime> LotDate { get; set; }
        public Nullable<System.DateTime> trandate { get; set; }
        public string en_grade_key { get; set; }
        public Nullable<short> an_pckablty_key { get; set; }
        public string en_stats_key { get; set; }
        public string in_item_revno { get; set; }
    }
}
