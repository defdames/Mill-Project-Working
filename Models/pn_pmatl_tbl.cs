using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_pmatl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime pn_pordr_reqdt { get; set; }
        public short pn_pordr_seq { get; set; }
        public int pn_pmatl_key { get; set; }
        public System.DateTime pn_pmatl_reqdt { get; set; }
        public string pn_pmatl_ip { get; set; }
        public string sf_ingrd_key { get; set; }
        public string in_pkitm_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string im_pack_key { get; set; }
        public double pn_pmatl_nomqty { get; set; }
        public double pn_pmatl_qty { get; set; }
        public string pn_pmatl_uom { get; set; }
        public string in_whs_key { get; set; }
        public string pn_pmatl_inpk { get; set; }
        public string sf_rout_key { get; set; }
        public string pn_pmatl_fpack { get; set; }
        public int pn_pmatl_upcnt { get; set; }
    }
}
