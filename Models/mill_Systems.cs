using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mill_Systems
    {
        public int Systems_ID { get; set; }
        public string System_Name { get; set; }
        public string Active { get; set; }
        public string Force_Mill_Test_Data_Entry { get; set; }
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Created_by { get; set; }
        public string Modified_by { get; set; }
    }
}
