using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_entty_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string pn_entty_sourc { get; set; }
        public double pn_entty_pdmdtot { get; set; }
        public double pn_entty_pspytot { get; set; }
        public double pn_entty_nqoh { get; set; }
        public int pn_entty_upcnt { get; set; }
    }
}
