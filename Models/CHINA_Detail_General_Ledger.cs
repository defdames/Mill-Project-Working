using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_Detail_General_Ledger
    {
        public short gl_perod_id { get; set; }
        public short gl_perod_year { get; set; }
        public Nullable<int> GlTranKey { get; set; }
        public string gl_acct_key { get; set; }
        public Nullable<System.DateTime> GlTranDate { get; set; }
        public string GlTranDesc { get; set; }
        public Nullable<double> TranAmt { get; set; }
        public string GlDbcrFlag { get; set; }
        public string gl_acct_desc { get; set; }
        public double gl_pdbal_open { get; set; }
        public string gl_tran_ref2 { get; set; }
        public string gl_tran_applc { get; set; }
        public string gl_tran_ref1 { get; set; }
        public string Vendor { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
