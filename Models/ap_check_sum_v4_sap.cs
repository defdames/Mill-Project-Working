using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_sum_v4_sap
    {
        public int ap_chek_key { get; set; }
        public Nullable<double> sumnet { get; set; }
        public Nullable<double> sumnetsgd { get; set; }
        public Nullable<double> sumdisc { get; set; }
        public Nullable<double> sumgross { get; set; }
        public Nullable<double> sumgrosssgd { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_crncy_key { get; set; }
    }
}
