using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_hdr_ins
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_hdr_key { get; set; }
        public int im_insmst_key { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<System.DateTime> im_insmst_joindt { get; set; }
    }
}
