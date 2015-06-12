using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_spritm_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_spritm_key { get; set; }
        public short in_spritm_type { get; set; }
        public System.DateTime in_spritm_crtdt { get; set; }
        public System.DateTime in_spritm_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int in_spritm_upcnt { get; set; }
        public int in_spritm_advplnf { get; set; }
        public int in_spritm_advschf { get; set; }
        public string en_planfam_key { get; set; }
    }
}
