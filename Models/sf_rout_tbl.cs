using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rout_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string sf_rout_desc { get; set; }
        public int fm_prtins_key { get; set; }
        public short sf_opseq_type { get; set; }
        public Nullable<System.DateTime> sf_rout_effdt { get; set; }
        public Nullable<System.DateTime> sf_rout_inadt { get; set; }
        public string sf_rout_altop { get; set; }
        public double sf_rout_bldt { get; set; }
        public double sf_rout_btchz { get; set; }
        public string uom_key { get; set; }
        public short sf_rout_cpt { get; set; }
        public int sf_rout_nbtch { get; set; }
        public double sf_rout_ovlqt { get; set; }
        public short sf_rout_ovltp { get; set; }
        public short sf_rout_ppt { get; set; }
        public double sf_rout_uldt { get; set; }
        public double sf_rout_yield { get; set; }
        public int sf_rout_upcnt { get; set; }
    }
}
