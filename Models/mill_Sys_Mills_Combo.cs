using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mill_Sys_Mills_Combo
    {
        public int Sys_Mills_Combo_ID { get; set; }
        public string System { get; set; }
        public string Mill_ID { get; set; }
        public string Active { get; set; }
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Created_by { get; set; }
        public string Modified_by { get; set; }
    }
}
