using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class cost_summary_rollup_new
    {
        public string in_item_key { get; set; }
        public string pack { get; set; }
        public string sf_plant_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string ca_cstyp_id { get; set; }
        public double basecost_perunit { get; set; }
        public double bulkcost_perunit { get; set; }
        public double matlcost_perunit { get; set; }
        public double rsrcecost_perunit { get; set; }
        public double standard_cost { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
