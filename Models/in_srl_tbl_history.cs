using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_srl_tbl_history
    {
        public string gl_cmp_key { get; set; }
        public short gl_perod_id { get; set; }
        public short gl_perod_year { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_item_key { get; set; }
        public string in_lot_key { get; set; }
        public Nullable<System.DateTime> in_srl_cycdt { get; set; }
        public Nullable<double> in_srl_lctqt { get; set; }
        public Nullable<int> in_srl_lcycn { get; set; }
        public Nullable<int> in_cycno_key { get; set; }
        public Nullable<double> in_srl_qoh { get; set; }
        public Nullable<double> in_srl_costc { get; set; }
        public Nullable<int> in_srl_upcnt { get; set; }
        public Nullable<System.DateTime> in_srl_issdt { get; set; }
        public Nullable<System.DateTime> in_srl_recdt { get; set; }
        public Nullable<System.DateTime> in_srl_sysdt { get; set; }
        public Nullable<double> in_srl_pkrsv { get; set; }
    }
}
