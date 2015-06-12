using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_ptprcs_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public System.DateTime sf_frmla_effdt { get; set; }
        public System.DateTime sf_frmla_inadt { get; set; }
        public short sf_ptprcs_alflg { get; set; }
        public short sf_ptprcs_defqty { get; set; }
        public int sf_ptprcs_upcnt { get; set; }
    }
}
