using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_locn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public int in_locn_upcnt { get; set; }
        public string in_locn_rmt { get; set; }
        public string in_locn_nettf { get; set; }
        public string in_locn_type { get; set; }
        public double in_shelf_wdth { get; set; }
        public double in_shelf_dpth { get; set; }
        public double in_shelf_hgth { get; set; }
        public double in_shelf_ucap { get; set; }
        public string in_shelf_uom { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime in_locn_chgdt { get; set; }
        public System.DateTime in_locn_crtdt { get; set; }
        public string in_locn_desc { get; set; }
        public int in_locn_advschf { get; set; }
        public short in_locn_autoblendf { get; set; }
    }
}
