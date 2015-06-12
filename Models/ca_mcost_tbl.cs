using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ca_mcost_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public System.DateTime ca_mcost_effdt { get; set; }
        public short ca_cstyp_id { get; set; }
        public string sf_rout_key { get; set; }
        public Nullable<System.DateTime> ca_mcost_inadt { get; set; }
        public Nullable<System.DateTime> ca_mcost_lcsdt { get; set; }
        public Nullable<System.DateTime> ca_mcost_mtldt { get; set; }
        public Nullable<System.DateTime> ca_mcost_resdt { get; set; }
        public Nullable<System.DateTime> ca_mcost_ovhdt { get; set; }
        public double ca_mcost_matl { get; set; }
        public double ca_mcost_mtloh { get; set; }
        public double ca_mcost_rsrce { get; set; }
        public double ca_mcost_rsroh { get; set; }
        public double ca_mcost_subcn { get; set; }
        public double ca_mcost_suboh { get; set; }
        public double ca_mcost_cstdr { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string sa_user_key { get; set; }
        public double ca_mcost_oprt { get; set; }
        public short ca_mcost_apflg { get; set; }
        public double ca_mcost_ordqt { get; set; }
        public short ca_mcost_alflg { get; set; }
        public string ca_mcost_iotp { get; set; }
        public string sf_ingrd_uom { get; set; }
        public short ca_mcost_nrvf { get; set; }
        public short ca_mcost_sqtyflag { get; set; }
        public double ca_mcost_formulaqty { get; set; }
        public double ca_mcost_otherqty { get; set; }
        public double ca_mcost_runsizeqty { get; set; }
        public string ca_mcost_runsizeUOM { get; set; }
        public int ca_mcost_upcnt { get; set; }
        public double ca_mcost_othcst { get; set; }
        public double ca_mcost_mktcst { get; set; }
        public double ca_mcost_frtcst { get; set; }
        public double ca_mcost_cdcst { get; set; }
        public double ca_mcost_procst { get; set; }
        public double ca_mcost_prcst { get; set; }
        public double ca_mcost_brocst { get; set; }
        public double ca_mcost_brcst { get; set; }
        public double ca_mcost_pmocst { get; set; }
        public double ca_mcost_pmcst { get; set; }
        public double ca_mcost_bmocst { get; set; }
        public double ca_mcost_bmcst { get; set; }
        public short ca_mcost_ioflag { get; set; }
        public short ca_mcost_mpamethod { get; set; }
        public double ca_mcost_marketratio { get; set; }
        public double ca_mcost_otherratio { get; set; }
    }
}
