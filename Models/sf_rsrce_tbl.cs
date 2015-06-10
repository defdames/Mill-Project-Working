using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_rsrce_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_rsrce_key { get; set; }
        public short sf_rsrce_type { get; set; }
        public string sf_rsrce_desc { get; set; }
        public string sf_rsrce_dept { get; set; }
        public double sf_rsrce_units { get; set; }
        public double sf_rsrce_dycap { get; set; }
        public double sf_rsrce_yrcap { get; set; }
        public double sf_rsrce_sdirc { get; set; }
        public double sf_rsrce_sovhf { get; set; }
        public double sf_rsrce_sovhc { get; set; }
        public double sf_rsrce_pdirc { get; set; }
        public double sf_rsrce_povhf { get; set; }
        public double sf_rsrce_povhc { get; set; }
        public Nullable<System.DateTime> sf_rsrce_effdt { get; set; }
        public Nullable<System.DateTime> sf_rsrce_inadt { get; set; }
        public string uom_key { get; set; }
        public string sf_rsrce_locid { get; set; }
        public short sf_rsrce_bkflshf { get; set; }
        public short sf_rsrce_advschf { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime sf_rsrce_crtdt { get; set; }
        public System.DateTime sf_rsrce_chgdt { get; set; }
        public int sf_rsrce_upcnt { get; set; }
    }
}
