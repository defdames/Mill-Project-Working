using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_spritm_tbl
    {
        public string en_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string en_spritm_key { get; set; }
        public short en_spritm_type { get; set; }
        public short en_spritm_advplnf { get; set; }
        public short en_spritm_advschf { get; set; }
        public string en_planfam_key { get; set; }
        public System.DateTime en_spritm_crtdt { get; set; }
        public System.DateTime en_spritm_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_spritm_upcnt { get; set; }
    }
}
