using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rthdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rout_key { get; set; }
        public string sf_rthdr_desc { get; set; }
        public string sf_rthdr_stat { get; set; }
        public string sf_rout_typ { get; set; }
        public double sf_rthdr_runsz { get; set; }
        public string sf_rthdr_runuom { get; set; }
        public double sf_rthdr_runtm { get; set; }
        public string sf_stage_key { get; set; }
        public Nullable<short> sf_rthdr_grptyp { get; set; }
        public string sf_rsrcgrp_key { get; set; }
        public Nullable<double> sf_rthdr_apthrpt { get; set; }
        public int sf_rthdr_upcnt { get; set; }
    }
}
