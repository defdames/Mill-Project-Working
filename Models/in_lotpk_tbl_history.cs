using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_lotpk_tbl_history
    {
        public string gl_cmp_key { get; set; }
        public short gl_perod_id { get; set; }
        public short gl_perod_year { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_item_key { get; set; }
        public string in_lot_key { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<System.DateTime> in_lot_cycdt { get; set; }
        public Nullable<double> in_lot_lctqt { get; set; }
        public Nullable<int> in_lot_lcycn { get; set; }
        public Nullable<int> in_cycno_key { get; set; }
        public Nullable<double> in_lot_qoh { get; set; }
        public Nullable<System.DateTime> in_lotpk_issdt { get; set; }
        public Nullable<System.DateTime> in_lotpk_recdt { get; set; }
        public Nullable<double> in_lotpk_lcst { get; set; }
        public Nullable<int> in_lotpk_upcnt { get; set; }
        public Nullable<System.DateTime> in_lotpk_sysdt { get; set; }
        public Nullable<double> in_lotpk_pkrsv { get; set; }
    }
}
