using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class cost_analysis_historic_sj
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string cost_year { get; set; }
        public string uom_key { get; set; }
        public Nullable<decimal> in_whitm_scst { get; set; }
        public Nullable<decimal> in_whitm_bmscst { get; set; }
        public Nullable<decimal> in_whitm_pmscst { get; set; }
        public Nullable<decimal> in_whitm_bmoscst { get; set; }
        public Nullable<decimal> in_whitm_pmoscst { get; set; }
        public Nullable<decimal> in_whitm_brscst { get; set; }
        public Nullable<decimal> in_whitm_prscst { get; set; }
        public Nullable<decimal> in_whitm_broscst { get; set; }
        public Nullable<decimal> in_whitm_proscst { get; set; }
        public string item { get; set; }
        public string packkey { get; set; }
        public string company { get; set; }
        public string manufacturingloc { get; set; }
        public Nullable<int> yearsold { get; set; }
        public Nullable<double> poundssoldlc { get; set; }
        public Nullable<double> dollarssoldlc { get; set; }
        public Nullable<double> avgpricelb { get; set; }
    }
}
