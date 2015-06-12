using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_sum_v3
    {
        public int CheckNo { get; set; }
        public string VendorId { get; set; }
        public string RemitId { get; set; }
        public Nullable<int> RemitAdr { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
