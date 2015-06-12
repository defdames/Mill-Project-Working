using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_wtdtl_ins
    {
        public string gl_cmp_key { get; set; }
        public string in_wthdr_towhs { get; set; }
        public string in_wthdr_key { get; set; }
        public short in_wtdtl_key { get; set; }
        public int im_insmst_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime im_insmst_joindt { get; set; }
    }
}
