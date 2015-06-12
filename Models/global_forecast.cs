using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class global_forecast
    {
        public string gl_cmp_key { get; set; }
        public string en_prod_key { get; set; }
        public System.DateTime datestamp { get; set; }
        public double quantity { get; set; }
        public string location { get; set; }
        public int id { get; set; }
    }
}
