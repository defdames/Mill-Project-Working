using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PlantMillHoursProducedDashboardForecast
    {
        public string fcst_year { get; set; }
        public string fcst_month { get; set; }
        public string sf_plant_key { get; set; }
        public Nullable<int> forecast { get; set; }
    }
}
