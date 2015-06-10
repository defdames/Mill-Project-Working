using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_itmpk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public short sf_itmpk_advplnf { get; set; }
        public short sf_itmpk_advschf { get; set; }
        public short sf_itmpk_type { get; set; }
        public string sf_asprdgrp_key { get; set; }
        public short sf_itmpk_prdschf { get; set; }
        public string in_spritm_asprd { get; set; }
        public short sf_itmpk_asdlvrf { get; set; }
        public System.DateTime sf_itmpk_crtdt { get; set; }
        public System.DateTime sf_itmpk_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int sf_itmpk_upcnt { get; set; }
    }
}
