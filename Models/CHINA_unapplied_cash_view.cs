using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_unapplied_cash_view
    {
        public string gl_cmp_key { get; set; }
        public string ar_chek_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_bill_name { get; set; }
        public Nullable<System.DateTime> tran_date_key { get; set; }
        public string ar_chek_refno { get; set; }
        public double ar_chek_amt { get; set; }
        public Nullable<double> unapplied_amount { get; set; }
        public string gl_paycd_key { get; set; }
        public string en_cust_key { get; set; }
        public Nullable<double> ar_chek_onacctf { get; set; }
    }
}
