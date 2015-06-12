using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_ptlot_tbl
    {
        public string en_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string en_lot_key { get; set; }
        public string en_itqsp_key { get; set; }
        public System.DateTime en_itqsp_effdt { get; set; }
        public System.DateTime en_ptlot_crtdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_ptlot_upcnt { get; set; }
        public int en_ptsublot_key { get; set; }
    }
}
