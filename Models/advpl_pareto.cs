using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_pareto
    {
        public string id { get; set; }
        public Nullable<double> Sales___0_kg { get; set; }
        public Nullable<double> Pct_Total_0_0_ { get; set; }
        public Nullable<double> Cum__0_0_ { get; set; }
        public int Rank { get; set; }
        public string Pareto { get; set; }
        public Nullable<bool> Diff_ { get; set; }
    }
}
