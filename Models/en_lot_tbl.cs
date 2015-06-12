using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_lot_tbl
    {
        public string en_item_key { get; set; }
        public string en_lot_key { get; set; }
        public string en_vend_key { get; set; }
        public string en_lot_extlt { get; set; }
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<System.DateTime> en_lot_mfgdt { get; set; }
        public string po_hdr_key { get; set; }
        public string pm_shop_key { get; set; }
        public System.DateTime en_lot_smpdt { get; set; }
        public System.DateTime en_lot_crtdt { get; set; }
        public Nullable<System.DateTime> en_lot_expdt { get; set; }
        public Nullable<System.DateTime> en_lot_fidt { get; set; }
        public short en_lot_pri { get; set; }
        public Nullable<double> en_lot_pot { get; set; }
        public Nullable<System.DateTime> en_lot_aprdt { get; set; }
        public Nullable<System.DateTime> en_lot_rejdt { get; set; }
        public Nullable<System.DateTime> en_lot_hlddt { get; set; }
        public string qc_stats_key { get; set; }
        public string en_grade_key { get; set; }
        public string en_lot_text { get; set; }
        public string en_hold_key { get; set; }
        public short en_lot_type { get; set; }
        public int en_lot_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime en_lot_chgdt { get; set; }
        public string en_lot_cool { get; set; }
        public string qc_source_key { get; set; }
        public string in_whs_key { get; set; }
    }
}
