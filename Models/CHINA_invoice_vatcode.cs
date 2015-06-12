using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_invoice_vatcode
    {
        public string gl_cmp_key { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public Nullable<double> VATAMT { get; set; }
    }
}
