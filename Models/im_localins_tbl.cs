using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class im_localins_tbl
    {
        public int im_localins_key { get; set; }
        public int im_instp_key { get; set; }
        public int im_prpmst_key { get; set; }
        public Nullable<int> im_insmst_key { get; set; }
        public int im_localins_flag { get; set; }
        public int im_cppmst_key { get; set; }
        public string im_insmst_extfile { get; set; }
        public System.DateTime im_insmst_effdt { get; set; }
        public Nullable<System.DateTime> im_insmst_inadt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime im_localins_chgdt { get; set; }
        public int im_localins_upcnt { get; set; }
    }
}
