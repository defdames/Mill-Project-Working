using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_sched_tbl
    {
        public string pn_sched_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string pn_sched_type { get; set; }
        public string pn_sched_entty { get; set; }
        public string pn_sched_desc { get; set; }
        public short pn_sched_tmfce { get; set; }
        public short pn_sched_horzn { get; set; }
        public string pn_fcast_key { get; set; }
        public string pn_sched_ovly { get; set; }
        public short pn_sched_rshin { get; set; }
        public short pn_sched_rshot { get; set; }
        public double pn_sched_ssdip { get; set; }
        public string pn_sched_hldpd { get; set; }
        public string pn_sched_hldps { get; set; }
        public short pn_sched_lvlcd { get; set; }
        public string pn_sched_relvl { get; set; }
        public short pn_sched_rshif { get; set; }
        public short pn_sched_rshof { get; set; }
        public string pn_sched_pnlvl { get; set; }
        public int pn_sched_upcnt { get; set; }
    }
}
