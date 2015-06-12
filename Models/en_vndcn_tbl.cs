using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_vndcn_tbl
    {
        public string en_vend_key { get; set; }
        public short im_contp_key { get; set; }
        public int im_cntct_key { get; set; }
        public int en_vndcn_upcnt { get; set; }
        public System.DateTime en_vndcn_crtdt { get; set; }
        public string en_stats_key { get; set; }
        public System.DateTime en_vndcn_chgdt { get; set; }
        public string sa_user_key { get; set; }
    }
}
