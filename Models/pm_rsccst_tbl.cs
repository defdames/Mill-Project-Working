using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_rsccst_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string sf_rout_key { get; set; }
        public short sf_opseq_key { get; set; }
        public short sf_step_seq { get; set; }
        public string sf_rsrce_key { get; set; }
        public double pm_rsccst_frztm { get; set; }
        public double pm_rsccst_fubscst { get; set; }
        public double pm_rsccst_fbscst { get; set; }
        public double pm_rsccst_fovhcst { get; set; }
        public short pm_rsccst_ffdflg { get; set; }
        public double pm_rsccst_sdrtm { get; set; }
        public double pm_rsccst_subscst { get; set; }
        public double pm_rsccst_sbscst { get; set; }
        public double pm_rsccst_sovhcst { get; set; }
        public short pm_rsccst_sfdflg { get; set; }
        public double pm_rsccst_exptm { get; set; }
        public double pm_rsccst_eubscst { get; set; }
        public double pm_rsccst_ebscst { get; set; }
        public double pm_rsccst_eovhcst { get; set; }
        public short pm_rsccst_efdflg { get; set; }
        public double pm_rsccst_reqtm { get; set; }
        public double pm_rsccst_rubscst { get; set; }
        public double pm_rsccst_rbscst { get; set; }
        public double pm_rsccst_rovhcst { get; set; }
        public short pm_rsccst_rfdflg { get; set; }
        public double pm_rsccst_acttm { get; set; }
        public double pm_rsccst_aubscst { get; set; }
        public double pm_rsccst_abscst { get; set; }
        public double pm_rsccst_aovhcst { get; set; }
        public short pm_rsccst_afdflg { get; set; }
        public int pm_rsccst_upcnt { get; set; }
        public string pm_rsccst_screw { get; set; }
        public Nullable<double> pm_rsccst_scrwqty { get; set; }
        public string pm_rsccst_rcrew { get; set; }
        public Nullable<double> pm_rsccst_rcrwqty { get; set; }
        public string pm_rsccst_acrew { get; set; }
        public Nullable<double> pm_rsccst_acrwqty { get; set; }
    }
}
