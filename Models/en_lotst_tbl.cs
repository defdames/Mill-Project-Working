using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_lotst_tbl
    {
        public string en_item_key { get; set; }
        public string en_lot_key { get; set; }
        public string en_itqsp_key { get; set; }
        public System.DateTime en_itqsp_effdt { get; set; }
        public string im_pack_key { get; set; }
        public short en_lotst_stats { get; set; }
        public Nullable<System.DateTime> en_lotst_aprdt { get; set; }
        public Nullable<System.DateTime> en_lotst_rejdt { get; set; }
        public string en_lotst_text { get; set; }
        public string en_sppck_key { get; set; }
        public string en_lotst_aprby { get; set; }
        public int en_lotst_upcnt { get; set; }
    }
}
