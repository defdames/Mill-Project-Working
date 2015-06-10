using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ca_ipcost_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime ca_itpck_effdt { get; set; }
        public short ca_cstyp_id { get; set; }
        public double im_itmpk_qty { get; set; }
        public string im_itmpk_uom { get; set; }
        public System.DateTime ca_itpck_inadt { get; set; }
        public System.DateTime ca_itpck_lcsdt { get; set; }
        public string im_itmpk_cntnr { get; set; }
        public System.DateTime im_pack_chgdt { get; set; }
        public string im_pack_stat { get; set; }
        public string im_pack_type { get; set; }
        public string im_pack_uid { get; set; }
        public double ca_ipcost_ordqt { get; set; }
        public string bm_asy_key { get; set; }
        public string uom_key { get; set; }
        public string sf_rout_key { get; set; }
        public short ca_itpck_cmth { get; set; }
        public short in_mohcd_fdflg { get; set; }
        public double in_mohcd_factr { get; set; }
        public double in_mohcd_dollr { get; set; }
        public double ca_ipcost_nomqty { get; set; }
        public int im_pkcst_upcnt { get; set; }
        public int ca_ipcost_numpk { get; set; }
        public double ca_itpck_cst { get; set; }
        public double ca_ipmtl_cst { get; set; }
        public double ca_ipres_cst { get; set; }
        public double ca_ipovh_cst { get; set; }
        public double ca_ipmtloh_cst { get; set; }
        public double ca_ipresoh_cst { get; set; }
        public double ca_item_cst { get; set; }
        public double ca_ipcost_bmcst { get; set; }
        public double ca_ipcost_bmocst { get; set; }
        public double ca_ipcost_pmcst { get; set; }
        public double ca_ipcost_pmocst { get; set; }
        public double ca_ipcost_brcst { get; set; }
        public double ca_ipcost_brocst { get; set; }
        public double ca_ipcost_prcst { get; set; }
        public double ca_ipcost_procst { get; set; }
        public double ca_ipcost_cdcst { get; set; }
        public double ca_ipcost_frtcst { get; set; }
        public double ca_ipcost_mktcst { get; set; }
        public double ca_ipcost_othcst { get; set; }
    }
}
