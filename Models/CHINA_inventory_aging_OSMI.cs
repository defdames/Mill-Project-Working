using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_inventory_aging_OSMI
    {
        public string in_item_key { get; set; }
        public string in_whs_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_lot_key { get; set; }
        public Nullable<double> in_lot_qoh { get; set; }
        public Nullable<double> in_whitmpk_scst { get; set; }
        public Nullable<System.DateTime> en_lot_mfgdt { get; set; }
        public string in_comcd_key { get; set; }
        public Nullable<decimal> pounds { get; set; }
        public string gl_cmp_key { get; set; }
        public string en_ituse_key { get; set; }
        public string in_abcc { get; set; }
        public string ItemStatus { get; set; }
        public Nullable<decimal> lb_in_lot_qoh { get; set; }
        public Nullable<double> ext_cost { get; set; }
        public Nullable<decimal> kg_in_lot_qoh { get; set; }
    }
}
