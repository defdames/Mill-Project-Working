using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_exces_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string pn_entty_sourc { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime pn_date { get; set; }
        public double pn_qty { get; set; }
        public int pn_exces_upcnt { get; set; }
        public string im_pack_key { get; set; }
        public double pn_bulk_qty { get; set; }
        public string uom_key { get; set; }
        public string pn_repack_fl { get; set; }
        public int pn_repack_seq { get; set; }
        public short pn_exces_stat { get; set; }
    }
}
