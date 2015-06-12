using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_reqhst_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int po_reqhd_key { get; set; }
        public short po_reqdt_key { get; set; }
        public string po_hdr_key { get; set; }
        public short po_dtl_key { get; set; }
        public double po_reqhst_issqt { get; set; }
        public System.DateTime po_reqhst_issdt { get; set; }
        public System.DateTime po_reqhst_crtdt { get; set; }
        public System.DateTime po_reqhst_chgdt { get; set; }
        public int po_reqhst_upcnt { get; set; }
        public string sa_user_key { get; set; }
    }
}
