using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_locgrp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locgrp_key { get; set; }
        public string in_locgrp_desc { get; set; }
        public int in_locgrp_tankf { get; set; }
        public System.DateTime in_locgrp_crtdt { get; set; }
        public System.DateTime in_locgrp_chgdt { get; set; }
        public int in_locgrp_upcnt { get; set; }
        public short in_locgrp_cycntf { get; set; }
        public string sa_user_key { get; set; }
    }
}
