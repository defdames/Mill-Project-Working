using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_srl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_item_key { get; set; }
        public string in_lot_key { get; set; }
        public Nullable<System.DateTime> in_srl_cycdt { get; set; }
        public double in_srl_lctqt { get; set; }
        public int in_srl_lcycn { get; set; }
        public int in_cycno_key { get; set; }
        public double in_srl_qoh { get; set; }
        public double in_srl_costc { get; set; }
        public int in_srl_upcnt { get; set; }
        public Nullable<System.DateTime> in_srl_issdt { get; set; }
        public Nullable<System.DateTime> in_srl_recdt { get; set; }
        public System.DateTime in_srl_sysdt { get; set; }
        public double in_srl_pkrsv { get; set; }
        public Nullable<double> in_srl_aqoh { get; set; }
    }
}
