using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_cyhist_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_cycnt_key { get; set; }
        public int in_cycnt_seqno { get; set; }
        public double in_cycnt_adjqty { get; set; }
        public double in_cycnt_orgcnt { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public double in_cyhist_cost { get; set; }
        public int in_cyhist_upcnt { get; set; }
        public double in_cyhist_qoh { get; set; }
        public System.DateTime in_cyhist_sysdt { get; set; }
    }
}
