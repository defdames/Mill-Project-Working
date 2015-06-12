using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_vessel_report_by_shipping_term
    {
        public string DocKey { get; set; }
        public Nullable<System.DateTime> TranDateKey { get; set; }
        public string DocType { get; set; }
        public string DocKeyType { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string ar_bill_name { get; set; }
        public string ar_bill_key { get; set; }
        public string so_hdr_key { get; set; }
        public double ar_ivhdr_ivblc { get; set; }
        public string gl_cmp_key { get; set; }
        public string country { get; set; }
        public string gl_crncy_key { get; set; }
        public string so_dtl_fobds { get; set; }
        public string vessel { get; set; }
        public Nullable<System.DateTime> shipping_dates { get; set; }
        public string ports_from_to { get; set; }
    }
}
