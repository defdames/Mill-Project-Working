using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bm_encmp_tbl
    {
        public string bm_asy_key { get; set; }
        public string bm_cmp_key { get; set; }
        public string im_pack_key { get; set; }
        public System.DateTime bm_cmp_effdt { get; set; }
        public short bm_cmp_flag { get; set; }
        public System.DateTime bm_cmp_inadt { get; set; }
        public double bm_cmp_yld { get; set; }
        public double bm_cmp_qpa { get; set; }
        public string bm_cmp_uom { get; set; }
        public double bm_cmp_wgt { get; set; }
        public double bm_cmp_exwgt { get; set; }
        public string bm_cmp_wuom { get; set; }
    }
}
