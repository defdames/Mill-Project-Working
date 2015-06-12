using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pr_prdgrp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_prod_key { get; set; }
        public string en_prgrp_key { get; set; }
        public string pr_prdgrp_comment { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<System.DateTime> pr_prdgrp_crtdt { get; set; }
        public Nullable<System.DateTime> pr_prdgrp_chgdt { get; set; }
        public int pr_prdgrp_upcnt { get; set; }
    }
}
