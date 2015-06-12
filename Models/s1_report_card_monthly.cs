using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class s1_report_card_monthly
    {
        public string s1_year { get; set; }
        public string s1_month { get; set; }
        public string region { get; set; }
        public string customer { get; set; }
        public string customer_update { get; set; }
        public string acctshr_region_cmp_1 { get; set; }
        public Nullable<double> acctshr_tam_lbs_1 { get; set; }
        public Nullable<double> acctshr_silb_lbs_1 { get; set; }
        public Nullable<double> acctshr_comp_lbs_1 { get; set; }
        public string acctshr_region_cmp_2 { get; set; }
        public Nullable<double> acctshr_tam_lbs_2 { get; set; }
        public Nullable<double> acctshr_silb_lbs_2 { get; set; }
        public Nullable<double> acctshr_comp_lbs_2 { get; set; }
        public string acctshr_region_cmp_3 { get; set; }
        public Nullable<double> acctshr_tam_lbs_3 { get; set; }
        public Nullable<double> acctshr_silb_lbs_3 { get; set; }
        public Nullable<double> acctshr_comp_lbs_3 { get; set; }
        public string product_needs_issues { get; set; }
        public string acctshr_uom { get; set; }
    }
}
