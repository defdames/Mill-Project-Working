using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_cntrdtlsl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string en_pkgtyp_key { get; set; }
        public string en_mfrid_key { get; set; }
        public string in_cntrhdr_srlno { get; set; }
        public string in_cntrhdr_ckdgt { get; set; }
        public int in_pick_key { get; set; }
        public int in_pkpeg_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_locn_key { get; set; }
        public int in_sublot_key { get; set; }
        public int in_cntrdtlsl_upcnt { get; set; }
    }
}
