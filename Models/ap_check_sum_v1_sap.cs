using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_sum_v1_sap
    {
        public string CheckNo { get; set; }
        public Nullable<double> CheckAmt { get; set; }
        public Nullable<double> CheckAmtSGD { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string gl_cmp_key { get; set; }
        public string RemitTo { get; set; }
    }
}
