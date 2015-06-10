using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_statecd_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ap_statecd_key { get; set; }
        public string ap_statecd_desc { get; set; }
        public System.DateTime ap_statecd_crtdt { get; set; }
        public System.DateTime ap_statecd_chgdt { get; set; }
        public short ap_statecd_dirpayf { get; set; }
        public int ap_statecd_upcnt { get; set; }
    }
}
