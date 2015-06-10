using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_vndjn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string en_vend_key { get; set; }
        public string ap_remt_key { get; set; }
        public string ap_delfm_key { get; set; }
        public string ap_stats_key { get; set; }
        public Nullable<System.DateTime> ap_vndjn_chgdt { get; set; }
        public int ap_vndjn_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<System.DateTime> ap_vndjn_crtdt { get; set; }
    }
}
