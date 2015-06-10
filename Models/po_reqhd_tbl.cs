using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_reqhd_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int po_reqhd_key { get; set; }
        public short po_reqhd_type { get; set; }
        public string po_reqhd_persn { get; set; }
        public System.DateTime po_reqhd_entdt { get; set; }
        public int po_reqhd_upcnt { get; set; }
        public short po_reqhd_aprvf { get; set; }
        public string po_reqhd_cmmts { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime po_reqhd_crtdt { get; set; }
        public System.DateTime po_reqhd_chgdt { get; set; }
        public string po_reqhd_persnemail { get; set; }
        public string po_reqhd_externalref { get; set; }
        public Nullable<System.DateTime> po_reqhd_clsdt { get; set; }
        public int po_reqhd_eamid { get; set; }
        public string at_in_sgid { get; set; }
    }
}
