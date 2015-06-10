using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_tran_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public short pm_tran_type { get; set; }
        public int pm_tran_key { get; set; }
        public System.DateTime pm_tran_time { get; set; }
        public string in_whs_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_locn_key { get; set; }
        public int pm_matl_key { get; set; }
        public string sa_user_key { get; set; }
        public string in_item_key { get; set; }
        public double pm_tran_bulkqty { get; set; }
        public string pm_tran_bulkuom { get; set; }
        public string im_pack_key { get; set; }
        public double pm_tran_packqty { get; set; }
        public string pm_tran_packuom { get; set; }
        public double pm_tran_bscst { get; set; }
        public double pm_tran_actcst { get; set; }
        public double pm_tran_ovhcst { get; set; }
        public string in_mohcd_key { get; set; }
        public string sf_rout_key { get; set; }
        public string sf_rsrce_key { get; set; }
        public short sf_opseq_key { get; set; }
        public short sf_step_seq { get; set; }
        public short pm_stpbk_key { get; set; }
        public double pm_tran_rsrctm { get; set; }
        public short pm_tran_fdflg { get; set; }
        public double pm_tran_factr { get; set; }
        public double pm_tran_dollr { get; set; }
        public short sf_cstdr_id { get; set; }
        public short pm_tran_ubflg { get; set; }
        public short pm_tran_mrbnf { get; set; }
        public short pm_stpbk_shift { get; set; }
        public string sf_ptdept_key { get; set; }
        public string sf_crew_key { get; set; }
        public Nullable<double> sf_crew_qty { get; set; }
        public Nullable<int> gl_trace_key { get; set; }
        public int pm_tran_upcnt { get; set; }
    }
}
