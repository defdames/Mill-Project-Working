using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_pack_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string sf_ingrd_key { get; set; }
        public string im_pack_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string sf_rout_key { get; set; }
        public double pm_pack_reqqty { get; set; }
        public double pm_pack_repqty { get; set; }
        public double pm_pack_orgqty { get; set; }
        public string pm_pack_pkuom { get; set; }
        public string pm_pack_tranuom { get; set; }
        public double sf_ptitmpk_yldfac { get; set; }
        public double pm_pack_nbereqqty { get; set; }
        public double pm_pack_nberepqty { get; set; }
        public double pm_pack_aberepqty { get; set; }
        public double pm_pack_orgnbeqty { get; set; }
        public string pm_pack_blkuom { get; set; }
        public double pm_pack_frzqty { get; set; }
        public double pm_pack_frzcst { get; set; }
        public int im_instr_key { get; set; }
        public string pn_fpo_batchid { get; set; }
        public string sf_ptdept_key { get; set; }
        public System.DateTime pm_pack_crtdt { get; set; }
        public System.DateTime pm_pack_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int pm_pack_upcnt { get; set; }
    }
}
