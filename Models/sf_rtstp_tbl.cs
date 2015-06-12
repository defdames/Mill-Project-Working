using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rtstp_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public short sf_step_seq { get; set; }
        public string sf_crew_key { get; set; }
        public Nullable<System.DateTime> sf_rout_inadt { get; set; }
        public string sf_rsrce_key { get; set; }
        public string sf_rtstp_cappf { get; set; }
        public string sf_rtstp_desc { get; set; }
        public double sf_rtstp_stdtm { get; set; }
        public string sf_rtstp_ubflg { get; set; }
        public short sf_step_id { get; set; }
        public string sf_tool_key { get; set; }
        public string sf_rsrcgrp_key { get; set; }
        public int sf_rtstp_upcnt { get; set; }
        public short sf_opseq_type { get; set; }
        public Nullable<double> sf_crew_qty { get; set; }
        public Nullable<double> sf_rtstp_thrput { get; set; }
        public Nullable<double> sf_rtstp_effncy { get; set; }
        public Nullable<System.DateTime> sf_rout_effdt { get; set; }
        public string sf_qctst_id { get; set; }
    }
}
