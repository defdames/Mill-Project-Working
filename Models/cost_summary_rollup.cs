using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class cost_summary_rollup
    {
        public string in_item_key { get; set; }
        public string pack { get; set; }
        public string sf_plant_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public short ca_cstyp_id { get; set; }
        public Nullable<double> basecost_perunit { get; set; }
        public Nullable<double> bulkcost_perunit { get; set; }
        public Nullable<double> matlcost_perunit { get; set; }
        public Nullable<double> rsrcecost_perunit { get; set; }
        public Nullable<double> standard_cost { get; set; }
    }
}
