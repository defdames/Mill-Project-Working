using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class otif_dashboard_week
    {
        public string gl_cmp_key { get; set; }
        public string weektime { get; set; }
        public Nullable<int> otiffail { get; set; }
        public Nullable<int> otiffull { get; set; }
        public Nullable<double> otif { get; set; }
    }
}
