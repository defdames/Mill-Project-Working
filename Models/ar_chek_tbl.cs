using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_chek_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_chek_key { get; set; }
        public string ar_bill_key { get; set; }
        public Nullable<System.DateTime> tran_date_key { get; set; }
        public Nullable<System.DateTime> comp_date_key { get; set; }
        public string ar_chek_type { get; set; }
        public string ar_chek_refno { get; set; }
        public string ap_bank_key { get; set; }
        public string ap_bank_acctno { get; set; }
        public double ar_chek_amt { get; set; }
        public double ar_chek_amtf { get; set; }
        public string gl_crncy_key { get; set; }
        public double ar_chek_rate { get; set; }
        public string ar_chek_stat { get; set; }
        public string ar_chek_dbank { get; set; }
        public string ar_chek_dbrch { get; set; }
        public Nullable<System.DateTime> ar_chek_expdt { get; set; }
        public string ar_chek_remk { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime ar_chek_chgdt { get; set; }
        public System.DateTime ar_chek_crtdt { get; set; }
        public Nullable<System.DateTime> ar_chek_duedt { get; set; }
        public int ar_chek_upcnt { get; set; }
        public Nullable<System.DateTime> ar_chek_stdte { get; set; }
        public Nullable<System.DateTime> ar_chek_presdt { get; set; }
        public string ar_drafts_key { get; set; }
        public string gl_paycd_key { get; set; }
        public short ar_chek_payst { get; set; }
        public double ar_chek_origto3 { get; set; }
        public double ar_chek_tobase { get; set; }
        public Nullable<System.DateTime> ar_chek_asofdt { get; set; }
        public string ar_batch_key { get; set; }
        public short ar_chek_manf { get; set; }
        public short ar_chek_onacctf { get; set; }
        public string en_cust_key { get; set; }
        public string ar_chek_lboxno { get; set; }
        public Nullable<double> ar_chek_ratetobtch { get; set; }
        public string ar_chek_onacctbill { get; set; }
        public double ar_chek_onacctcf { get; set; }
        public Nullable<short> ar_chek_bnkclr { get; set; }
        public string gl_bkcd_key { get; set; }
        public double ar_chek_amtfb { get; set; }
        public double ar_chek_deductcf { get; set; }
        public Nullable<int> gl_bank_key { get; set; }
        public Nullable<System.DateTime> ar_chek_stmtdt { get; set; }
        public double ar_chek_appamt { get; set; }
        public double ar_chek_appamtf { get; set; }
        public double ar_chek_cramt { get; set; }
        public double ar_chek_cramtf { get; set; }
        public double ar_chek_deduct { get; set; }
        public Nullable<System.DateTime> ar_chek_date { get; set; }
    }
}
