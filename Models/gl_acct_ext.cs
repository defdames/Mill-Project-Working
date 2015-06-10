using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_acct_ext
    {
        public string gl_cmp_key { get; set; }
        public string gl_acct_key { get; set; }
        public string interco_gl_cmp_key { get; set; }
        public int gl_acct_upcnt { get; set; }
    }
}
