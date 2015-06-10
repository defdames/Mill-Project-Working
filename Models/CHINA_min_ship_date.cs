using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_min_ship_date
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_hdr_key { get; set; }
        public string so_dtl_shpws { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
    }
}
