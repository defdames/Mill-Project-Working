using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_sum_v4
    {
        public int ap_chek_key { get; set; }
        public Nullable<double> sumnet { get; set; }
        public Nullable<double> sumdisc { get; set; }
        public Nullable<double> sumgross { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
