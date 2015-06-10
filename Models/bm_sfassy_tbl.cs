using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bm_sfassy_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string bm_asy_key { get; set; }
        public string bm_asy_desc { get; set; }
        public short bm_asy_typ { get; set; }
        public double bm_asy_yld { get; set; }
        public double bm_asy_wgt { get; set; }
        public string bm_asy_wuom { get; set; }
        public double bm_asy_vol { get; set; }
        public string bm_asy_vuom { get; set; }
        public double bm_asy_blkqty { get; set; }
        public string bm_asy_blkuom { get; set; }
    }
}
