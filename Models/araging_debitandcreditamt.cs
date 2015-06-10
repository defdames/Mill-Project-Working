using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class araging_debitandcreditamt
    {
        public string InvKey { get; set; }
        public Nullable<decimal> DebitAmt { get; set; }
        public string gl_cmp_key { get; set; }
        public Nullable<decimal> DebitAmtf { get; set; }
        public string creditinc { get; set; }
    }
}
