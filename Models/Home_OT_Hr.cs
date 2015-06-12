using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Home_OT_Hr
    {
        public string Name { get; set; }
        public Nullable<double> clock { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Refused { get; set; }
        public Nullable<double> Adjusted_Hrs { get; set; }
        public string Comments { get; set; }
        public Nullable<double> Worked { get; set; }
        public Nullable<double> Night_Worked { get; set; }
        public Nullable<double> Night_Refused { get; set; }
        public string Dept { get; set; }
        public int primarykey { get; set; }
    }
}
