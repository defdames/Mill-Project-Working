using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dbcrmhdr_ins
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public int im_insmst_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime im_insmst_joindt { get; set; }
    }
}
