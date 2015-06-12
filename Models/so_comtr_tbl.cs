using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_comtr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int so_comtr_key { get; set; }
        public string so_salsm_key { get; set; }
        public string so_comtr_type { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string so_ship_key { get; set; }
        public string gl_acct_key { get; set; }
        public double so_comtr_soamt { get; set; }
        public double so_comtr_cmval { get; set; }
        public double so_comtr_booked { get; set; }
        public double so_comtr_due { get; set; }
        public double so_comtr_paid { get; set; }
        public string so_comtr_stats { get; set; }
        public Nullable<System.DateTime> so_comtr_pysldt { get; set; }
        public System.DateTime so_comtr_trndt { get; set; }
        public string so_comtr_ref { get; set; }
        public int ap_chek_key { get; set; }
        public int so_comtr_upcnt { get; set; }
        public short so_comtr_cmtypf { get; set; }
        public string so_comtr_cmuom { get; set; }
        public string gl_paycd_key { get; set; }
        public string gl_bkcd_key { get; set; }
        public string gl_cmp_profit { get; set; }
        public string so_brnch_profit { get; set; }
        public string gl_crncy_key { get; set; }
        public double so_comtr_rate { get; set; }
        public Nullable<System.DateTime> so_comtr_asofdt { get; set; }
        public double so_comtr_origto3 { get; set; }
        public double so_comtr_tobase { get; set; }
        public double so_comtr_bookedcf { get; set; }
        public double so_comtr_duecf { get; set; }
        public double so_comtr_paidcf { get; set; }
        public string so_comtr_reftype { get; set; }
        public string so_comtr_refnum { get; set; }
        public int so_inbcom_key { get; set; }
        public Nullable<short> so_comtr_reflnnum { get; set; }
    }
}
