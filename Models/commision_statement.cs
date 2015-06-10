using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class commision_statement
    {
        public string so_salsm_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string so_salsm_name { get; set; }
        public string so_salsm_adr1 { get; set; }
        public string so_salsm_adr2 { get; set; }
        public string so_salsm_adr3 { get; set; }
        public string so_salsm_city { get; set; }
        public string so_salsm_cntry { get; set; }
        public string so_salsm_pczip { get; set; }
        public string doc { get; set; }
        public System.DateTime so_comtr_trndt { get; set; }
        public double so_comtr_due { get; set; }
        public double so_comtr_paid { get; set; }
        public string en_ship_name { get; set; }
        public Nullable<double> ar_ivhdr_ivblc { get; set; }
        public Nullable<double> ar_ivhdr_crmoc { get; set; }
        public Nullable<double> ar_ivhdr_cdisc { get; set; }
        public Nullable<double> ar_ivhdr_cshc { get; set; }
        public Nullable<double> ar_ivhdr_wroffc { get; set; }
    }
}
