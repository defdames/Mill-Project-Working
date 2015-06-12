using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_cntrhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string en_pkgtyp_key { get; set; }
        public string en_mfrid_key { get; set; }
        public string in_cntrhdr_srlno { get; set; }
        public string in_cntrhdr_ckdgt { get; set; }
        public string in_cntrhdr_id { get; set; }
        public int in_cntrhdr_status { get; set; }
        public string in_cntrhdr_trkno { get; set; }
        public string in_cntrhdr_refno { get; set; }
        public string en_uom_key { get; set; }
        public short in_cntrhdr_return { get; set; }
        public string so_load_key { get; set; }
        public int in_cntrhdr_upcnt { get; set; }
        public string en_pkgtyp_ptkey { get; set; }
        public string en_mfrid_ptkey { get; set; }
        public string in_cntrhdr_ptsrlno { get; set; }
        public string in_cntrhdr_ptckdgt { get; set; }
    }
}
