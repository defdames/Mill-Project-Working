using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_msctr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_msctr_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_lot_key { get; set; }
        public double in_msctr_qty { get; set; }
        public string in_msctr_type { get; set; }
        public System.DateTime in_msctr_date { get; set; }
        public int sa_frame_id { get; set; }
        public string in_msctr_enttp { get; set; }
        public string in_msctr_entid { get; set; }
        public string in_msctr_ordtp { get; set; }
        public string in_msctr_cmpid { get; set; }
        public string in_msctr_ordid { get; set; }
        public System.DateTime in_msctr_crtdt { get; set; }
        public System.DateTime in_msctr_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public string in_msctr_remk { get; set; }
        public short in_msctr_seq { get; set; }
        public string ap_resn_key { get; set; }
        public int in_msctr_upcnt { get; set; }
    }
}
