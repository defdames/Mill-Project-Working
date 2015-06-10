using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_shopstp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public short sf_step_seq { get; set; }
        public string sf_rsrce_key { get; set; }
        public double sf_rtstp_stdtm { get; set; }
        public string sf_rtstp_ubflg { get; set; }
        public int fm_prtins_key { get; set; }
        public double pm_shopstp_acttm { get; set; }
        public int pm_shopstp_upcnt { get; set; }
        public string sf_crew_key { get; set; }
        public Nullable<double> sf_crew_qty { get; set; }
    }
}
