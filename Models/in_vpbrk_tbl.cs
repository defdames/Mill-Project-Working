using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_vpbrk_tbl
    {
        public int in_vpbrk_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string in_whs_key { get; set; }
        public string ap_delfm_key { get; set; }
        public string en_vend_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public System.DateTime in_vpbrk_effdt { get; set; }
        public double in_vpbrk_bklvl { get; set; }
        public System.DateTime in_vpbrk_inadt { get; set; }
        public short in_vpbrk_bkflg { get; set; }
        public double in_vpbrk_quote { get; set; }
        public double in_vpbrk_disc { get; set; }
        public double in_vpbrk_discc { get; set; }
        public Nullable<System.DateTime> in_vpbrk_lqtdt { get; set; }
        public string in_vpbrk_cmnts { get; set; }
        public string en_uom_pruom { get; set; }
        public int in_vpbrk_upcnt { get; set; }
        public short in_vpbrk_type { get; set; }
    }
}
