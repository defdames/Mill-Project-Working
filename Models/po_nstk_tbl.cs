using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_nstk_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_nstk_key { get; set; }
        public string en_uom_key { get; set; }
        public string po_nstk_desc { get; set; }
        public string po_nstk_acct { get; set; }
        public int po_nstk_upcnt { get; set; }
        public string en_1099_key { get; set; }
        public string en_stats_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public int po_nstk_apprf { get; set; }
        public int po_nstk_eamf { get; set; }
        public short po_nstk_servicef { get; set; }
    }
}
