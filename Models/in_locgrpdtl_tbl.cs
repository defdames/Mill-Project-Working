using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_locgrpdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locgrp_key { get; set; }
        public string in_locn_key { get; set; }
        public System.DateTime in_locgrpdtl_crtdt { get; set; }
        public System.DateTime in_locgrpdtl_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int in_locgrpdtl_upcnt { get; set; }
    }
}
