using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_resn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ap_resn_key { get; set; }
        public string ap_resn_desc { get; set; }
        public int ap_resn_upcnt { get; set; }
        public string ap_resn_type { get; set; }
        public string gl_acct_key { get; set; }
        public short ap_resn_recalc { get; set; }
    }
}
