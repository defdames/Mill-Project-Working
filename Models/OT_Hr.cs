using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class OT_Hr
    {
        public double clock { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Refused { get; set; }
        public Nullable<double> Worked { get; set; }
        public string Reason { get; set; }
        public Nullable<double> TimeMissed { get; set; }
    }
}
