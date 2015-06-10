using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pr_promo_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pr_promo_key { get; set; }
        public string pr_promo_desc { get; set; }
        public short pr_promo_type { get; set; }
        public short pr_promo_prec { get; set; }
        public string pr_promo_situation { get; set; }
        public string pr_promo_comment { get; set; }
        public double pr_promo_budget { get; set; }
        public string gl_crncy_key { get; set; }
        public string pr_cmpgn_key { get; set; }
        public string pr_promo_crtby { get; set; }
        public System.DateTime pr_promo_crtdt { get; set; }
        public string pr_promo_appby { get; set; }
        public Nullable<System.DateTime> pr_promo_appdt { get; set; }
        public Nullable<short> pr_promo_inact { get; set; }
        public short pr_promo_method { get; set; }
        public short pr_promo_addchnf { get; set; }
        public Nullable<double> pr_promo_offinv { get; set; }
        public Nullable<double> pr_promo_accrued { get; set; }
        public Nullable<double> pr_promo_maxamt { get; set; }
        public string ar_terms_key { get; set; }
        public string pr_promo_libac { get; set; }
        public string pr_promo_expac { get; set; }
        public short pr_promo_allow { get; set; }
        public short pr_promo_ordshp { get; set; }
        public short pr_promo_applyto { get; set; }
        public short pr_promo_duration { get; set; }
        public short pr_promo_disperse { get; set; }
        public short pr_promo_accrue { get; set; }
        public short pr_promo_cashdisf { get; set; }
        public short pr_promo_itemizef { get; set; }
        public short pr_promo_commf { get; set; }
        public short pr_promo_taxf { get; set; }
        public short pr_promo_accsel { get; set; }
        public string pr_promo_acckey { get; set; }
        public Nullable<System.DateTime> pr_promo_expdt { get; set; }
        public Nullable<int> pr_promo_exptime { get; set; }
        public Nullable<short> pr_promo_expint { get; set; }
        public Nullable<System.DateTime> pr_promo_lastdt { get; set; }
        public Nullable<int> pr_promo_lasttime { get; set; }
        public Nullable<short> pr_promo_lastint { get; set; }
        public Nullable<System.DateTime> pr_promo_chgdt { get; set; }
        public Nullable<int> pr_promo_upcnt { get; set; }
        public string pr_promo_chgby { get; set; }
        public short pr_promo_useavailf { get; set; }
        public Nullable<System.DateTime> pr_promo_cncldt { get; set; }
        public string pr_resn_key { get; set; }
        public short pr_promo_appvf { get; set; }
        public short pr_promo_appseq { get; set; }
        public Nullable<System.DateTime> pr_promo_ordefdt { get; set; }
        public Nullable<System.DateTime> pr_promo_ordiadt { get; set; }
        public Nullable<System.DateTime> pr_promo_shpefdt { get; set; }
        public Nullable<System.DateTime> pr_promo_shpiadt { get; set; }
        public short pr_promo_ordefff { get; set; }
        public short pr_promo_shpefff { get; set; }
        public short pr_promo_multicmpf { get; set; }
        public short pr_promo_incicprcf { get; set; }
        public string so_enduse_key { get; set; }
        public string en_sltyp_key { get; set; }
        public short pr_promo_reprchgf { get; set; }
        public string so_brand_key { get; set; }
    }
}
