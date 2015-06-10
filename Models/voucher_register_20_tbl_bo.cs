using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class voucher_register_20_tbl_bo
    {
        public string VKey { get; set; }
        public string VType { get; set; }
        public string AcctKey { get; set; }
        public string DCType { get; set; }
        public double glamt { get; set; }
        public Nullable<int> seq { get; set; }
        public string company { get; set; }
    }
}
