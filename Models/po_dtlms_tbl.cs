using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_dtlms_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public short po_dtl_key { get; set; }
        public string en_misc_key { get; set; }
        public string gl_acct_key { get; set; }
        public short po_dtlms_cttyp { get; set; }
        public short po_dtlms_ctuff { get; set; }
        public double po_dtlms_ctval { get; set; }
        public string uom_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime po_dtlms_crtdt { get; set; }
        public System.DateTime po_dtlms_chgdt { get; set; }
        public int po_dtlms_upcnt { get; set; }
        public short po_dtlms_taxf { get; set; }
        public string ar_tax_key { get; set; }
        public string en_contr_key { get; set; }
        public double po_dtlms_extvalcf { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public double po_dtlms_vatc { get; set; }
        public double po_dtlms_vatcf { get; set; }
        public short po_dtlms_computef { get; set; }
        public int po_dtlms_seqno { get; set; }
        public double po_dtlms_extvalc { get; set; }
    }
}
