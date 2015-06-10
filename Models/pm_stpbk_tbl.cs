using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_stpbk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public short sf_step_seq { get; set; }
        public short pm_stpbk_key { get; set; }
        public string sf_rsrce_key { get; set; }
        public Nullable<System.DateTime> pm_stpbk_bdte { get; set; }
        public double pm_stpbk_bqty { get; set; }
        public short pm_stpbk_shift { get; set; }
        public string sa_user_key { get; set; }
        public int pm_stpbk_upcnt { get; set; }
        public string sf_crew_key { get; set; }
        public Nullable<double> sf_crew_qty { get; set; }
    }
}
