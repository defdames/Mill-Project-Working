using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_tran_tbl
    {
        public int in_tran_key { get; set; }
        public string in_tran_type { get; set; }
        public int in_trandtl_key { get; set; }
        public int in_trnum_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_cmp_location { get; set; }
        public string gl_cmp_demand { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_locn_key { get; set; }
        public double in_tran_qty { get; set; }
        public Nullable<double> in_tran_afill { get; set; }
        public string en_uom_afill { get; set; }
        public Nullable<double> in_tran_extcst { get; set; }
        public string in_tran_enttp { get; set; }
        public string in_tran_entid { get; set; }
        public string in_tran_demandid { get; set; }
        public string in_tran_demandtp { get; set; }
        public Nullable<int> in_tran_demandline { get; set; }
        public string in_tran_origin { get; set; }
        public string in_tran_origintp { get; set; }
        public Nullable<int> in_tran_originline { get; set; }
        public string in_tran_origentid { get; set; }
        public string in_tran_origenttp { get; set; }
        public string in_tran_refdoc { get; set; }
        public System.DateTime in_tran_date { get; set; }
        public System.DateTime in_tran_sysdt { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<double> in_tran_mqty { get; set; }
        public string en_uom_measured { get; set; }
        public Nullable<double> in_tran_aqty { get; set; }
        public Nullable<int> en_subtype_key { get; set; }
        public string en_uom_alternate { get; set; }
        public Nullable<int> gl_trace_key { get; set; }
    }
}
