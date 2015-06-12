using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_lotpk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_item_key { get; set; }
        public string in_lot_key { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<System.DateTime> in_lot_cycdt { get; set; }
        public double in_lot_lctqt { get; set; }
        public int in_lot_lcycn { get; set; }
        public int in_cycno_key { get; set; }
        public double in_lot_qoh { get; set; }
        public Nullable<System.DateTime> in_lotpk_issdt { get; set; }
        public Nullable<System.DateTime> in_lotpk_recdt { get; set; }
        public double in_lotpk_lcst { get; set; }
        public int in_lotpk_upcnt { get; set; }
        public System.DateTime in_lotpk_sysdt { get; set; }
        public double in_lotpk_pkrsv { get; set; }
        public Nullable<double> in_lotpk_aqoh { get; set; }
    }
}
