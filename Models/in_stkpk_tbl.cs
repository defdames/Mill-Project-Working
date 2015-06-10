using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_stkpk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string in_locn_key { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<System.DateTime> in_locn_issdt { get; set; }
        public Nullable<System.DateTime> in_locn_recdt { get; set; }
        public Nullable<System.DateTime> in_stock_cycdt { get; set; }
        public Nullable<System.DateTime> in_locn_tagdt { get; set; }
        public double in_stock_lctqt { get; set; }
        public int in_stock_lcycn { get; set; }
        public int in_cycno_key { get; set; }
        public double in_locn_qoh { get; set; }
        public int in_stkpk_upcnt { get; set; }
        public System.DateTime in_stkpk_sysdt { get; set; }
        public double in_stkpk_pkrsv { get; set; }
        public Nullable<double> in_stkpk_aqoh { get; set; }
    }
}
