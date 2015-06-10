using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_delfm_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ap_delfm_key { get; set; }
        public int ap_delfm_upcnt { get; set; }
        public string ap_delfm_name { get; set; }
        public short ap_delfm_shmth { get; set; }
        public short ap_delfm_holdf { get; set; }
        public string en_stats_key { get; set; }
        public string en_whs_key { get; set; }
        public string en_frgt_key { get; set; }
        public string ap_delfm_cmnts { get; set; }
        public short ap_delfm_taxf { get; set; }
        public string ap_resn_key { get; set; }
        public string ap_statecd_key { get; set; }
        public short ap_delfm_type { get; set; }
        public string en_trnsport_key { get; set; }
        public string en_fob_key { get; set; }
        public Nullable<double> ap_delfm_minqty { get; set; }
        public string en_uom_minqty { get; set; }
        public Nullable<double> ap_delfm_minamt { get; set; }
        public string gl_crncy_minamt { get; set; }
    }
}
