using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_payments_SLL
    {
        public string ap_remt_key { get; set; }
        public string ap_remt_name { get; set; }
        public Nullable<System.DateTime> ap_vchr_pysldt { get; set; }
        public double amount { get; set; }
        public double VATamt { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
