using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_ptdept_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_ptdept_key { get; set; }
        public string sf_ptdept_sdesc { get; set; }
        public string sf_ptdept_name { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime sf_ptdept_crtdt { get; set; }
        public System.DateTime sf_ptdept_chgdt { get; set; }
        public int sf_ptdept_upcnt { get; set; }
        public short sf_ptdept_dfltf { get; set; }
    }
}
