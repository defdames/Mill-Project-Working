using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_inventory_dashboard
    {
        public string gl_cmp_key { get; set; }
        public string type { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
        public Nullable<decimal> in_stkmv_eoh { get; set; }
        public Nullable<double> in_stkmv_eoh_cost { get; set; }
    }
}
