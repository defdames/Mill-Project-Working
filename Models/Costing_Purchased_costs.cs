using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Costing_Purchased_costs
    {
        public string in_item_key { get; set; }
        public string in_whitm_sourc { get; set; }
        public string uom_key { get; set; }
        public double in_whitm_pcst { get; set; }
        public double in_whitm_scst { get; set; }
        public string gl_acct_key { get; set; }
        public string in_desc { get; set; }
    }
}
