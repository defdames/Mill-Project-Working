using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class otif_dashboard
    {
        public string gl_cmp_key { get; set; }
        public string monthtime { get; set; }
        public Nullable<int> otiffail { get; set; }
        public Nullable<int> otiffull { get; set; }
        public Nullable<double> otif { get; set; }
    }
}
