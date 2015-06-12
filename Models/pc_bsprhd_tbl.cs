using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pc_bsprhd_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pc_bsprhd_key { get; set; }
        public string pc_bsprhd_desc { get; set; }
        public string pc_bsprhd_exdesc { get; set; }
        public short pc_bsprhd_inact { get; set; }
        public string gl_crncy_key { get; set; }
        public short pc_bsprhd_type { get; set; }
        public int pc_bsprhd_upcnt { get; set; }
        public System.DateTime pc_bsprhd_crtdt { get; set; }
        public System.DateTime pc_bsprhd_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public short pc_bsprhd_reprchgf { get; set; }
    }
}
