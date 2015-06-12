using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_araging_debitamt
    {
        public string InvKey { get; set; }
        public Nullable<decimal> DebitAmt { get; set; }
        public string gl_cmp_key { get; set; }
        public string ar_dbcrm_stats { get; set; }
        public Nullable<decimal> DebitAmtf { get; set; }
    }
}
