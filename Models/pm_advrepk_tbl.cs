using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_advrepk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string pm_advrepk_spack { get; set; }
        public string pm_advrepk_tpack { get; set; }
        public int pm_advrepk_advschf { get; set; }
        public int pm_advrepk_pstpver { get; set; }
        public System.DateTime pm_advrepk_crtdt { get; set; }
        public System.DateTime pm_advrepk_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public string pm_advrepk_astplid { get; set; }
        public int pm_advrepk_upcnt { get; set; }
    }
}
