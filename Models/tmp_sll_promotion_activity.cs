using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tmp_sll_promotion_activity
    {
        public string pr_accrue_hdr { get; set; }
        public int pr_accrue_dtl { get; set; }
        public int pr_accrue_seq { get; set; }
        public string gl_cmp_ship { get; set; }
        public string so_brnch_ship { get; set; }
        public short pr_accrue_type { get; set; }
        public string pr_promo_acckey { get; set; }
        public Nullable<short> pr_promo_accsel { get; set; }
        public Nullable<System.DateTime> pr_accrue_crtdt { get; set; }
        public Nullable<double> pr_accrue_offinv { get; set; }
        public Nullable<double> pr_accrue_amt { get; set; }
        public double pr_accrue_amtdisb { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_ivhdr_key { get; set; }
        public Nullable<int> ar_ivdtl_key { get; set; }
        public string pr_elmnt_key { get; set; }
        public string so_prod_desc { get; set; }
        public string en_bill_key { get; set; }
        public string en_bill_name { get; set; }
        public string so_salsm_key { get; set; }
        public string so_salsm_name { get; set; }
    }
}
