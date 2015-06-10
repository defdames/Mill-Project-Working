using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rsrcgrp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rsrcgrp_key { get; set; }
        public string sf_rsrcgrp_desc { get; set; }
        public short sf_rsrcgrp_advschf { get; set; }
        public short sf_rsrcgrp_type { get; set; }
        public System.DateTime sf_rsrcgrp_crtdt { get; set; }
        public System.DateTime sf_rsrcgrp_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int sf_rsrcgrp_upcnt { get; set; }
    }
}
