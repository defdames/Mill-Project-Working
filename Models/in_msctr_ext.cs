using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_msctr_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_msctr_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_lot_key { get; set; }
        public string ap_resn_key { get; set; }
        public short in_msctr_seq { get; set; }
        public Nullable<double> hours { get; set; }
        public Nullable<double> dollars { get; set; }
        public int in_msctr_upcnt { get; set; }
    }
}
