using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_payhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int ap_payhdr_key { get; set; }
        public string ap_bank_key { get; set; }
        public string ap_bank_acctno { get; set; }
        public short ap_payhdr_type { get; set; }
        public string ap_payhdr_chekty { get; set; }
        public string ap_payhdr_tranref { get; set; }
        public System.DateTime ap_payhdr_seldt { get; set; }
        public Nullable<System.DateTime> ap_payhdr_paydt { get; set; }
        public Nullable<System.DateTime> ap_payhdr_voddt { get; set; }
        public Nullable<System.DateTime> ap_payhdr_prtdt { get; set; }
        public Nullable<System.DateTime> ap_payhdr_presdt { get; set; }
        public string ap_payhdr_stats { get; set; }
        public string ap_payhdr_clstat { get; set; }
        public string ap_payhdr_desc { get; set; }
        public string ap_payhdr_ref { get; set; }
        public string ap_payhdr_entid { get; set; }
        public string ap_payhdr_entnm { get; set; }
        public int im_adres_key { get; set; }
        public double ap_payhdr_amt { get; set; }
        public double ap_payhdr_amtf { get; set; }
        public string gl_crncy_key { get; set; }
        public string ap_resn_key { get; set; }
        public string sa_user_key { get; set; }
        public string prog_nam { get; set; }
        public System.DateTime ap_payhdr_crtdt { get; set; }
        public System.DateTime ap_payhdr_chgdt { get; set; }
        public int ap_payhdr_upcnt { get; set; }
        public string gl_paycd_key { get; set; }
        public short ap_payhdr_payst { get; set; }
        public Nullable<System.DateTime> ap_payhdr_duedt { get; set; }
        public string gl_bkcd_key { get; set; }
    }
}
