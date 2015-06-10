using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Attendance
    {
        public string Employee_Name { get; set; }
        public System.DateTime Date { get; set; }
        public string Reason { get; set; }
        public Nullable<double> Time_Missed { get; set; }
        public string Remarks { get; set; }
        public Nullable<double> Days_Used { get; set; }
        public Nullable<float> Vac_Hrs_Pd { get; set; }
    }
}
