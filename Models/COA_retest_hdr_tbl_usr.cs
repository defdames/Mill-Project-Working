using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COA_retest_hdr_tbl_usr
    {
        public System.DateTime date { get; set; }
        public string item { get; set; }
        public string lot { get; set; }
        public string test { get; set; }
        public string result { get; set; }
    }
}
