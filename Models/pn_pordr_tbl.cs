using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_pordr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public string pn_entty_sourc { get; set; }
        public System.DateTime pn_pordr_reqdt { get; set; }
        public short pn_pordr_seq { get; set; }
        public System.DateTime pn_pordr_reldt { get; set; }
        public double pn_pordr_ordqt { get; set; }
        public string pn_actnm_key { get; set; }
        public string pn_fpo_key { get; set; }
        public string pn_pordr_plnt { get; set; }
        public double pn_pordr_yqty { get; set; }
        public string en_vend_key { get; set; }
        public string ap_remt_key { get; set; }
        public string ap_delfm_key { get; set; }
        public string in_wthdr_towhs { get; set; }
        public string in_wthdr_frwhs { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string sf_rout_key { get; set; }
        public double pn_pordr_bulkqty { get; set; }
        public short pn_pordr_target { get; set; }
        public int pn_pordr_upcnt { get; set; }
    }
}
