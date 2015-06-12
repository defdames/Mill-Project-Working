using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class AP_Wire_Register
    {
        public string Chk_num { get; set; }
        public Nullable<System.DateTime> Chk_dte { get; set; }
        public string Ven_num { get; set; }
        public Nullable<double> Pay_Amt { get; set; }
        public string Currency { get; set; }
        public Nullable<double> Discamt { get; set; }
        public Nullable<double> Voucher_amt { get; set; }
        public string Invnum { get; set; }
        public Nullable<System.DateTime> InvDate { get; set; }
        public string Ven_nam { get; set; }
        public string CkStat { get; set; }
        public Nullable<double> Chk_amt { get; set; }
        public string Clrd_outst { get; set; }
        public Nullable<System.DateTime> Dat_Clrd { get; set; }
        public string gl_cmp_key { get; set; }
        public string ap_vchr_key { get; set; }
    }
}
