using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class global_costs
    {
        public Nullable<int> Year { get; set; }
        public string IN_WHS_KEY { get; set; }
        public string en_prod_key { get; set; }
        public Nullable<double> LBCost { get; set; }
        public Nullable<double> KGcost { get; set; }
        public Nullable<double> GlobalMatlCostLB { get; set; }
        public Nullable<double> GlobalDirectLaborlb { get; set; }
        public Nullable<double> GlobalVariableCostlb { get; set; }
        public string company { get; set; }
    }
}
