using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_cstjn_tbl
    {
        public string en_cust_key { get; set; }
        public string en_bill_key { get; set; }
        public string en_ship_key { get; set; }
        public string en_stats_key { get; set; }
        public System.DateTime en_cstjn_chgdt { get; set; }
        public int en_cstjn_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime en_cstjn_crtdt { get; set; }
    }
}
