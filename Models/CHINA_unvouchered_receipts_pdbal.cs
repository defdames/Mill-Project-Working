using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_unvouchered_receipts_pdbal
    {
        public string Acct { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<System.DateTime> PdStartDate { get; set; }
        public Nullable<System.DateTime> PdEndDate { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
