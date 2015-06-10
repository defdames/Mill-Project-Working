using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class cost_summary_lifo
    {
        public string in_item_key { get; set; }
        public string pack { get; set; }
        public string sf_plant_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public short ca_cstyp_id { get; set; }
        public double basecost_perunit { get; set; }
        public double bulkcost_perunit { get; set; }
        public double matlcost_perunit { get; set; }
        public double rsrcecost_perunit { get; set; }
        public double standard_cost { get; set; }
        public Nullable<short> ca_mcost_alflg { get; set; }
        public Nullable<double> overhead { get; set; }
    }
}
