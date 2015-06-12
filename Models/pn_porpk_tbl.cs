using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_porpk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string pn_entty_sourc { get; set; }
        public System.DateTime pn_pordr_reqdt { get; set; }
        public short pn_pordr_seq { get; set; }
        public double pn_porpk_ordqt { get; set; }
        public double pn_porpk_yldfac { get; set; }
        public double pn_porpk_yldblk { get; set; }
        public string sf_rout_key { get; set; }
        public int pn_porpk_upcnt { get; set; }
    }
}
