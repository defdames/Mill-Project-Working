using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dbcrm_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public short ar_dbcrdtl_key { get; set; }
        public string comments { get; set; }
        public string product_returned { get; set; }
        public int ar_dbcrm_upcnt { get; set; }
    }
}
