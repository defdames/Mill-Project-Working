using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_retrn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_retrn_key { get; set; }
        public System.DateTime po_retrn_retdt { get; set; }
        public string po_recpt_key { get; set; }
        public string po_hdr_key { get; set; }
        public string po_retrn_dbmem { get; set; }
        public string po_retrn_rma { get; set; }
        public short po_retrn_eustatf { get; set; }
        public Nullable<System.DateTime> po_retrn_eustatdt { get; set; }
        public string en_fob_key { get; set; }
        public string en_trnsport_key { get; set; }
        public int po_retrn_upcnt { get; set; }
        public System.DateTime po_retrn_chgdt { get; set; }
        public System.DateTime po_retrn_crtdt { get; set; }
        public string sa_user_key { get; set; }
        public string en_carr_key { get; set; }
        public string po_retrn_bolno { get; set; }
        public string en_mode_key { get; set; }
        public string en_serv_key { get; set; }
        public string po_rtreq_key { get; set; }
    }
}
