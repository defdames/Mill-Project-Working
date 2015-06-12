using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class LbsPerMillHr_v2_metalyield
    {
        public string pm_shop_key { get; set; }
        public string sf_plant_key { get; set; }
        public string gl_cmp_key { get; set; }
        public Nullable<double> ingred_qty { get; set; }
    }
}
