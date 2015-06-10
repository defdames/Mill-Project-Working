using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_unvouchered_receipts_v2
    {
        public int Seq { get; set; }
        public string Acct { get; set; }
        public string DocNo { get; set; }
        public string DocType { get; set; }
        public System.DateTime DocDate { get; set; }
        public string POKey { get; set; }
        public Nullable<double> Amt { get; set; }
        public Nullable<System.DateTime> GlDate { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<int> POStatus { get; set; }
        public string VendKey { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
