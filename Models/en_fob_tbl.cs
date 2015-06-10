using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_fob_tbl
    {
        public string en_fob_key { get; set; }
        public string en_fob_desc { get; set; }
        public short en_fob_ownf { get; set; }
        public System.DateTime en_fob_crtdt { get; set; }
        public System.DateTime en_fob_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_fob_upcnt { get; set; }
    }
}
