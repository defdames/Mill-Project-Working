using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class commodity_by_whse_01_summary
    {
        public string ItemKey { get; set; }
        public string PackKey { get; set; }
        public Nullable<double> Deca { get; set; }
        public Nullable<double> Home { get; set; }
        public Nullable<double> Lans { get; set; }
        public Nullable<double> Cle { get; set; }
        public Nullable<double> Pott { get; set; }
        public Nullable<double> Fwa { get; set; }
        public Nullable<double> Dtw { get; set; }
        public Nullable<double> Tide { get; set; }
        public Nullable<double> Star { get; set; }
        public Nullable<double> CONS { get; set; }
        public Nullable<double> Oth { get; set; }
        public Nullable<double> Tot { get; set; }
        public short PdMo { get; set; }
        public short PdYr { get; set; }
    }
}
