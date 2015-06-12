using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class voucher_register_10_tbl
    {
        public string VKey { get; set; }
        public string VType { get; set; }
        public string AcctKey { get; set; }
        public string AcctDesc { get; set; }
        public double amt { get; set; }
        public Nullable<int> seq { get; set; }
    }
}
