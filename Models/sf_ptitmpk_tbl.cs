using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_ptitmpk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string sf_rout_key { get; set; }
        public System.DateTime sf_ptitmpk_effdt { get; set; }
        public System.DateTime sf_ptitmpk_inadt { get; set; }
        public double sf_ptitmpk_yldfac { get; set; }
        public short sf_ptitmpk_rttype { get; set; }
        public int sf_ptitmpk_pstpver { get; set; }
        public string in_whs_key { get; set; }
        public string in_locgrp_key { get; set; }
        public string sf_ptitmpk_astplid { get; set; }
        public int sf_ptitmpk_upcnt { get; set; }
    }
}
