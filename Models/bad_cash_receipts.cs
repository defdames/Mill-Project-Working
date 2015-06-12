using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bad_cash_receipts
    {
        public string gl_cmp_key { get; set; }
        public string gl_interface_docno { get; set; }
        public Nullable<double> unapplied { get; set; }
        public Nullable<System.DateTime> tran_date_key { get; set; }
    }
}
