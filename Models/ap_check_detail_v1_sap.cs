using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_detail_v1_sap
    {
        public string gl_cmp_key { get; set; }
        public string ap_payhdr_tranref { get; set; }
        public Nullable<double> ap_paydtl_amt { get; set; }
        public Nullable<double> ap_paydtl_amtf { get; set; }
        public Nullable<int> ap_paydtl_key { get; set; }
        public string ap_paydtl_docno { get; set; }
    }
}
