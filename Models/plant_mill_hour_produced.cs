using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class plant_mill_hour_produced
    {
        public string sf_plant_key { get; set; }
        public Nullable<int> forecast { get; set; }
        public Nullable<double> actual { get; set; }
    }
}
