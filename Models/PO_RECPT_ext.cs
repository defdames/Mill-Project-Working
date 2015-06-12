using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PO_RECPT_ext
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_recpt_key { get; set; }
        public string po_recpt_vessel { get; set; }
        public Nullable<System.DateTime> po_recpt_vesdt { get; set; }
        public int PO_RECPT_upcnt { get; set; }
    }
}
