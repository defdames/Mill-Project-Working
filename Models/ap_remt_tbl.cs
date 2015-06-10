using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_remt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ap_remt_key { get; set; }
        public string ap_remt_name { get; set; }
        public string ap_bank_acctno { get; set; }
        public string ap_bank_key { get; set; }
        public double ap_remt_crbal { get; set; }
        public short ap_remt_holdf { get; set; }
        public Nullable<System.DateTime> ap_remt_invdt { get; set; }
        public double ap_remt_lstpd { get; set; }
        public string ap_remt_pacct { get; set; }
        public Nullable<System.DateTime> ap_remt_paddt { get; set; }
        public short ap_remt_pri { get; set; }
        public string ap_remt_tacct { get; set; }
        public double ap_remt_unapd { get; set; }
        public int ap_remt_upcnt { get; set; }
        public string ar_tax_key { get; set; }
        public string ar_terms_key { get; set; }
        public double ap_remt_unapc { get; set; }
        public string en_stats_key { get; set; }
        public string gl_crncy_key { get; set; }
        public short ap_remt_1099f { get; set; }
        public string gl_paycd_key { get; set; }
        public string ap_remt_regid { get; set; }
        public short ap_remt_type { get; set; }
        public short gl_vatcd_qlf { get; set; }
        public string gl_vatcd_key { get; set; }
        public short ap_remt_declp { get; set; }
        public short ap_remt_recalc { get; set; }
        public short ap_remt_incld { get; set; }
        public short ap_remt_curf { get; set; }
        public string gl_bkcd_key { get; set; }
        public short ap_remt_autovchf { get; set; }
        public string gl_cmp_pay { get; set; }
        public string gl_acct_disc { get; set; }
        public Nullable<int> ap_remt_dfltbk { get; set; }
        public short ap_remt_whldtaxf { get; set; }
        public string en_1099_key { get; set; }
    }
}
