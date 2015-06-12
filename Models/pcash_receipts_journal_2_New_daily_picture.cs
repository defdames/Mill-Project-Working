using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pcash_receipts_journal_2_New_daily_picture
    {
        public string BillTo { get; set; }
        public string CheckNo { get; set; }
        public Nullable<double> CrdAmt { get; set; }
        public Nullable<double> DbtAmt { get; set; }
        public string GlAcct { get; set; }
        public string GlAcctName { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string CheckRefNo { get; set; }
        public string ar_chek_key { get; set; }
        public string gl_acct_key { get; set; }
        public string gl_interface_ref1 { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
