using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pn_item_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pn_sched_key { get; set; }
        public string in_item_key { get; set; }
        public System.DateTime pn_item_plndt { get; set; }
        public int pn_item_upcnt { get; set; }
        public string sf_plant_key { get; set; }
        public string in_whs_key { get; set; }
        public string im_pack_key { get; set; }
        public string pn_item_flag { get; set; }
        public string pn_item_sourc { get; set; }
        public string pn_item_srcwhs { get; set; }
        public string uom_key { get; set; }
    }
}
