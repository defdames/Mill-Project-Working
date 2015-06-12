using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class active_routings_using_costing
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rout_key { get; set; }
        public double sf_rthdr_runtm { get; set; }
        public string sf_rsrce_key { get; set; }
        public Nullable<double> sf_rtstp_stdtm { get; set; }
        public double sf_rthdr_runsz { get; set; }
        public string sf_rthdr_runuom { get; set; }
        public Nullable<double> sf_rsrce_sdirc { get; set; }
        public Nullable<double> sf_rsrce_sovhf { get; set; }
        public Nullable<double> sf_rout_uldt_old { get; set; }
        public Nullable<double> sf_rout_uldt { get; set; }
        public Nullable<double> sf_rout_bldt { get; set; }
        public Nullable<double> uldt2 { get; set; }
    }
}
