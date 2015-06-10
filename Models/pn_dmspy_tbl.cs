using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_dmspy_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string pn_sched_entty { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime pn_date { get; set; }
        public string pn_dmspy_fl { get; set; }
        public string pn_doc_type { get; set; }
        public string pn_doc_key { get; set; }
        public short pn_dtl_key { get; set; }
        public string pn_loc_key { get; set; }
        public double pn_qty { get; set; }
        public string pn_ref_key { get; set; }
        public Nullable<System.DateTime> pn_edate { get; set; }
        public string im_pack_key { get; set; }
        public string ar_ship_key { get; set; }
        public int pn_dmspy_upcnt { get; set; }
        public string pn_dmspy_dmdco { get; set; }
        public string pn_dmspy_dmdenttp { get; set; }
        public string pn_dmspy_dmdentid { get; set; }
        public string pn_dmspy_dmditem { get; set; }
        public string pn_dmspy_dmdpack { get; set; }
        public int pn_dmspy_subtyp { get; set; }
        public string pn_dmspy_wtdswhs { get; set; }
        public decimal pn_dmspy_pk { get; set; }
    }
}
