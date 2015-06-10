using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_dtlrc_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_recpt_key { get; set; }
        public short po_dtl_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string po_hdr_key { get; set; }
        public double po_dtlrc_qty { get; set; }
        public double po_dtlrc_accqt { get; set; }
        public double po_dtlrc_rejqt { get; set; }
        public double po_dtlrc_retqt { get; set; }
        public double ap_vchdtl_invqt { get; set; }
        public double po_dtlrc_qoh { get; set; }
        public string en_uom_puom { get; set; }
        public double po_dtlrc_poqty { get; set; }
        public string en_uom_ruom { get; set; }
        public string en_uom_fuom { get; set; }
        public Nullable<double> po_dtlrc_totaqty { get; set; }
        public string po_dtlrc_cmnts { get; set; }
        public double po_dtlrc_prqty { get; set; }
        public string en_uom_pruom { get; set; }
        public double po_dtlrc_quotcf { get; set; }
        public double po_dtlrc_quotc { get; set; }
        public short po_dtlrc_coaf { get; set; }
        public double ap_invdtl_invqt { get; set; }
        public double po_dtlrc_stdcst { get; set; }
    }
}
