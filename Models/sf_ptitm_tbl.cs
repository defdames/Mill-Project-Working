using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_ptitm_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string sf_mfgrp_key { get; set; }
        public string uom_key { get; set; }
        public string bm_aprt_key { get; set; }
        public int sf_ptitm_mmthd { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_rout_key { get; set; }
        public string in_plnc_key { get; set; }
        public double in_bldt { get; set; }
        public double in_uldt { get; set; }
        public double in_yldf { get; set; }
        public double in_wipq { get; set; }
        public double in_wipaq { get; set; }
        public string gl_acct_key { get; set; }
        public double in_wiss { get; set; }
        public string multilvl_flag { get; set; }
        public short sf_ptitm_advplnf { get; set; }
        public short sf_ptitm_advschf { get; set; }
        public short sf_ptitm_type { get; set; }
        public string sf_asprdgrp_key { get; set; }
        public short sf_ptitm_prdschf { get; set; }
        public short sf_ptitm_asdlvrf { get; set; }
        public int sf_ptitm_upcnt { get; set; }
        public string in_spritm_asprd { get; set; }
    }
}
