using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_comcd_tbl
    {
        public string en_comcd_key { get; set; }
        public string en_comcd_desc { get; set; }
        public int en_comcd_upcnt { get; set; }
        public string en_comcd_indcd { get; set; }
        public double en_comcd_dtypc { get; set; }
        public string en_uom_key { get; set; }
        public System.DateTime en_comcd_crtdt { get; set; }
        public System.DateTime en_comcd_chgdt { get; set; }
        public string sa_user_key { get; set; }
    }
}
