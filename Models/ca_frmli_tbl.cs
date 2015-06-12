using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ca_frmli_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public System.DateTime ca_frmlo_effdt { get; set; }
        public short ca_frmlo_cstyp { get; set; }
        public string sf_ingrd_key { get; set; }
        public Nullable<System.DateTime> ca_frmlo_inadt { get; set; }
        public short ca_frmli_csmth { get; set; }
        public double ca_frmli_qpa { get; set; }
        public double sf_ingrd_yld { get; set; }
        public string uom_key { get; set; }
        public double ca_frmli_mtlv { get; set; }
        public double ca_frmli_ohv { get; set; }
        public short in_mohcd_fdflg { get; set; }
        public double in_mohcd_factr { get; set; }
        public double in_mohcd_dollr { get; set; }
        public double ca_frmli_formulaqty { get; set; }
        public int ca_frmli_upcnt { get; set; }
        public double ca_frmli_bmcst { get; set; }
        public double ca_frmli_bmocst { get; set; }
        public double ca_frmli_pmcst { get; set; }
        public double ca_frmli_pmocst { get; set; }
        public double ca_frmli_brcst { get; set; }
        public double ca_frmli_brocst { get; set; }
        public double ca_frmli_prcst { get; set; }
        public double ca_frmli_procst { get; set; }
        public double ca_frmli_cdcst { get; set; }
        public double ca_frmli_frtcst { get; set; }
        public double ca_frmli_mktcst { get; set; }
        public double ca_frmli_othcst { get; set; }
        public string in_whitm_sourc { get; set; }
        public double sf_ingrd_opyld { get; set; }
    }
}
