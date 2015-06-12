using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tbl_MSO_dtl
    {
        public int MSOno { get; set; }
        public string qty { get; set; }
        public string HazMat { get; set; }
        public string Description { get; set; }
        public string weight { get; set; }
        public string harmonized_code { get; set; }
        public string export_license_need { get; set; }
        public string country_of_origin { get; set; }
        public Nullable<decimal> value { get; set; }
        public int linenumber { get; set; }
    }
}
