using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_cntrdtl_tbl
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
        public string en_prod_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public double in_cntrdtl_qty { get; set; }
        public string en_uom_key { get; set; }
        public string in_cntrdtl_ordtyp { get; set; }
        public string in_cntrdtl_ordno { get; set; }
        public int in_cntrdtl_ordln { get; set; }
        public string in_cntrdtl_ordent { get; set; }
        public int in_cntrdtl_upcnt { get; set; }
        public string gl_cmp_demand { get; set; }
    }
}
