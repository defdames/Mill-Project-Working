using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_glb_overduepast
    {
        public string BillTo { get; set; }
        public string SoldTo { get; set; }
        public string SoldName { get; set; }
        public string SoldLine1 { get; set; }
        public string SoldLine2 { get; set; }
        public string SoldLine3 { get; set; }
        public string SoldCSZ { get; set; }
        public string IvhdrType { get; set; }
        public string HdrKey { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Charge { get; set; }
        public int Credit { get; set; }
        public string Salsm { get; set; }
        public Nullable<int> Remark { get; set; }
        public Nullable<int> StartAT { get; set; }
        public string Int_ { get; set; }
        public string so_hdr_cpono { get; set; }
        public string en_terms_desc { get; set; }
        public Nullable<int> daysdue { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
