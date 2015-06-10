using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Attendance_Table
    {
        public double Clock { get; set; }
        public System.DateTime Date { get; set; }
        public string Reason { get; set; }
        public Nullable<double> Time_Missed { get; set; }
        public string Remarks { get; set; }
    }
}
