using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_shop_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string pm_shop_ordtp { get; set; }
        public short pm_shop_subtyp { get; set; }
        public short pm_shop_stat { get; set; }
        public string in_item_key { get; set; }
        public string pm_shop_chnord { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string sf_rout_key { get; set; }
        public string pm_shop_dflot { get; set; }
        public double pm_shop_bqty { get; set; }
        public string pm_shop_buom { get; set; }
        public double pm_shop_nombqty { get; set; }
        public double pm_shop_orgbqty { get; set; }
        public double pm_shop_orgnbqty { get; set; }
        public Nullable<System.DateTime> pm_shop_stdt { get; set; }
        public System.DateTime pm_shop_reldt { get; set; }
        public Nullable<System.DateTime> pm_shop_duedt { get; set; }
        public Nullable<System.DateTime> pm_shop_entdt { get; set; }
        public Nullable<System.DateTime> pm_shop_pstdt { get; set; }
        public Nullable<System.DateTime> pm_shop_cmpldt { get; set; }
        public Nullable<System.DateTime> pm_shop_prclsdt { get; set; }
        public Nullable<System.DateTime> pm_shop_clsdt { get; set; }
        public int im_instr_key { get; set; }
        public string pm_shop_cust { get; set; }
        public string ar_ship_key { get; set; }
        public string pm_acct_grp { get; set; }
        public short pm_shop_alflg { get; set; }
        public string pm_shop_apkey { get; set; }
        public int pm_shop_apver { get; set; }
        public short pm_shop_type { get; set; }
        public string pn_fpo_batchid { get; set; }
        public short pm_shop_cstadjf { get; set; }
        public short so_dtl_expeditef { get; set; }
        public string sf_ptdept_key { get; set; }
        public Nullable<int> pm_shop_shift { get; set; }
        public short pm_shop_rwtype { get; set; }
        public int pm_shop_upcnt { get; set; }
        public string pm_shop_xrefid { get; set; }
        public string pn_fpo_remks { get; set; }
        public string pn_fpo_refkey { get; set; }
        public string pn_fpo_refkey2 { get; set; }
        public string pn_fpo_refkey3 { get; set; }
        public string pm_shop_relby { get; set; }
        public string pm_shop_cmplby { get; set; }
        public string pm_shop_prclsby { get; set; }
        public string pm_shop_clsby { get; set; }
        public string pm_shop_cmbord { get; set; }
    }
}
