using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_pgc_tbl
    {
        public string en_pgc_key { get; set; }
        public int en_pgc_upcnt { get; set; }
        public string en_pgc_dsc { get; set; }
        public System.DateTime en_pgc_crtdt { get; set; }
        public System.DateTime en_pgc_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public string en_pgc_stat { get; set; }
        public string en_pgc_cmnts { get; set; }
        public string en_plc_key { get; set; }
    }
}
