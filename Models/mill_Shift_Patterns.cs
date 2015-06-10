using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mill_Shift_Patterns
    {
        public int Shift_Patterns_ID { get; set; }
        public string Shift_ID { get; set; }
        public Nullable<int> Shift_Length_Hours { get; set; }
        public System.TimeSpan Shift_Start_Time { get; set; }
        public System.TimeSpan Shift_Stop_Time { get; set; }
        public string Shift_Active { get; set; }
        public string Comment { get; set; }
        public string Shift_Hours_Cross_Days { get; set; }
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Created_by { get; set; }
        public string Modified_by { get; set; }
    }
}
