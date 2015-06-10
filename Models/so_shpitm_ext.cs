using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_shpitm_ext
    {
        public string gl_cmp_key { get; set; }
        public string so_ship_entity { get; set; }
        public string so_ship_key { get; set; }
        public string so_ship_ordtp { get; set; }
        public short so_shpitm_key { get; set; }
        public string so_ship_dmdent { get; set; }
        public int so_shp_nopacks { get; set; }
        public double bulk_net_wgt { get; set; }
        public double actual_line_wgt { get; set; }
        public string so_shpitm_bolpack { get; set; }
        public Nullable<double> actual_cubic_meters { get; set; }
        public Nullable<double> no_pallets { get; set; }
        public string dl_remarks { get; set; }
        public int so_shpitm_upcnt { get; set; }
    }
}
