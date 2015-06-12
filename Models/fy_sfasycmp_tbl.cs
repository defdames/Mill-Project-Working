using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class fy_sfasycmp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string bm_asy_key { get; set; }
        public string bm_cmp_key { get; set; }
        public string im_pack_key { get; set; }
        public short bm_cmp_flag { get; set; }
        public System.DateTime bm_cmp_effdt { get; set; }
        public System.DateTime bm_cmp_inadt { get; set; }
        public double bm_cmp_yldqpa { get; set; }
        public string bm_cmp_uom { get; set; }
        public double fy_sfasycmp_yld { get; set; }
        public decimal fy_sfasycmp_pk { get; set; }
    }
}
