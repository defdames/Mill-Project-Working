using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_fpo_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pn_fpo_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime pn_fpo_reldt { get; set; }
        public System.DateTime pn_fpo_reqdt { get; set; }
        public double pn_fpo_yqty { get; set; }
        public double pn_fpo_reqqt { get; set; }
        public string sf_rout_key { get; set; }
        public string pn_fpo_remks { get; set; }
        public int pn_fpo_upcnt { get; set; }
        public int pn_grpnum_key { get; set; }
        public short pn_fpo_target { get; set; }
        public short pn_fpo_subtyp { get; set; }
        public short pn_fpo_origin { get; set; }
        public string en_vend_key { get; set; }
        public string ap_remt_key { get; set; }
        public string ap_delfm_key { get; set; }
        public string in_wthdr_towhs { get; set; }
        public string in_wthdr_frwhs { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string pn_fpo_refkey { get; set; }
        public string pn_fpo_refkey2 { get; set; }
        public string pn_fpo_refkey3 { get; set; }
        public string in_buyc_key { get; set; }
        public double pn_fpo_bulkqty { get; set; }
        public string pn_fpo_authby { get; set; }
        public Nullable<System.DateTime> pn_fpo_authdt { get; set; }
        public string in_whs_key { get; set; }
        public string pn_fpo_batchid { get; set; }
        public short pn_fpo_schdlf { get; set; }
        public System.DateTime pn_fpo_reqdttm { get; set; }
        public System.DateTime pn_fpo_startdttm { get; set; }
        public Nullable<System.DateTime> pn_fpo_dtstamp { get; set; }
        public string pn_fpo_orderid { get; set; }
        public string pn_fpo_modelid { get; set; }
        public int pn_fpo_pstpver { get; set; }
        public int pn_fpo_matlsubflg { get; set; }
        public int pn_fpo_rescsubflg { get; set; }
        public int pn_fpo_shift { get; set; }
        public string pn_fpo_ptbatch { get; set; }
    }
}
