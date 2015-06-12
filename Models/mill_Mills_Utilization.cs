using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mill_Mills_Utilization
    {
        public int Mills_Utilization_ID { get; set; }
        public string Mill_ID { get; set; }
        public string System { get; set; }
        public string Run_Code { get; set; }
        public Nullable<System.DateTime> Start_Time { get; set; }
        public Nullable<System.DateTime> Stop_Time { get; set; }
        public string Shift { get; set; }
        public Nullable<System.DateTime> Shift_Start_Date { get; set; }
        public Nullable<int> Mill_Hours_Booked { get; set; }
        public Nullable<System.DateTime> Shift_Start_Time { get; set; }
        public Nullable<System.DateTime> Shift_Stop_Time { get; set; }
        public string sa_user_key { get; set; }
        public string Memo { get; set; }
        public Nullable<int> SO_Number { get; set; }
        public string Item_Number { get; set; }
        public string Shift_Category { get; set; }
        public Nullable<int> Mill_temp { get; set; }
        public Nullable<int> D10 { get; set; }
        public Nullable<int> D50 { get; set; }
        public Nullable<int> D90 { get; set; }
        public Nullable<int> D98 { get; set; }
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Created_by { get; set; }
        public string Modified_by { get; set; }
    }
}
