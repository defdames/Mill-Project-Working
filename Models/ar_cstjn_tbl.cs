using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_cstjn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string en_cust_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_ship_key { get; set; }
        public string ar_stats_key { get; set; }
        public System.DateTime ar_cstjn_chgdt { get; set; }
        public int ar_cstjn_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime ar_cstjn_crtdt { get; set; }
    }
}
