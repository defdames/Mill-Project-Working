using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class qa_specification_customer_temp
    {
        public string Item { get; set; }
        public System.DateTime SpecEffDate { get; set; }
        public System.DateTime SpecInadtDate { get; set; }
        public string SpecGrpKey { get; set; }
        public string TestName { get; set; }
        public Nullable<double> MinValue { get; set; }
        public Nullable<double> MaxValue { get; set; }
        public Nullable<double> TargetValue { get; set; }
        public string QualValue { get; set; }
        public string TestUoM { get; set; }
        public string Recent { get; set; }
        public string en_qcmst_desc { get; set; }
        public Nullable<int> en_itqct_reqdf { get; set; }
        public string en_ship_key { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
