using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_planfam_tbl
    {
        public string en_planfam_key { get; set; }
        public string en_planfam_desc { get; set; }
        public System.DateTime en_planfam_crtdt { get; set; }
        public System.DateTime en_planfam_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_planfam_upcnt { get; set; }
    }
}
