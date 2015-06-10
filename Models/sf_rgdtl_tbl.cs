using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rgdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rsrcgrp_key { get; set; }
        public string sf_rsrce_key { get; set; }
        public System.DateTime sf_rgdtl_crtdt { get; set; }
        public System.DateTime sf_rgdtl_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int sf_rgdtl_upcnt { get; set; }
    }
}
