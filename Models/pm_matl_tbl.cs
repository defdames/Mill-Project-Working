using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_matl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public int pm_matl_key { get; set; }
        public string pm_matl_ip { get; set; }
        public string sf_ingrd_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_pkitm_key { get; set; }
        public string pm_matl_inpk { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public int pm_matl_seq { get; set; }
        public string pm_matl_fpack { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public double pm_matl_qty { get; set; }
        public double pm_matl_nomqty { get; set; }
        public double pm_matl_issqt { get; set; }
        public double pm_matl_retqt { get; set; }
        public double pm_matl_totaq { get; set; }
        public double pm_matl_pikqt { get; set; }
        public double pm_matl_pickd { get; set; }
        public double pm_matl_cnsmd { get; set; }
        public double pm_matl_scpqt { get; set; }
        public double pm_matl_recqt { get; set; }
        public string pm_matl_uom { get; set; }
        public string pm_matl_tranuom { get; set; }
        public double pm_matl_fqty { get; set; }
        public string pm_matl_fuom { get; set; }
        public string sf_ingrd_iotp { get; set; }
        public System.DateTime pm_matl_reqdt { get; set; }
        public short pm_matl_bkflsh { get; set; }
        public short pm_matl_rwrkf { get; set; }
        public int pm_matl_upcnt { get; set; }
        public string pm_matl_chnord { get; set; }
    }
}
