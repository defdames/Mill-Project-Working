using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_shplot_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_ship_entity { get; set; }
        public string so_ship_key { get; set; }
        public string so_ship_ordtp { get; set; }
        public short so_shpitm_key { get; set; }
        public short so_shiplot_key { get; set; }
        public double so_shiplot_qty { get; set; }
        public string in_lot_key { get; set; }
        public string in_whs_key { get; set; }
        public string gl_cmp_dmd { get; set; }
        public string so_ship_dmdent { get; set; }
        public Nullable<int> in_pick_key { get; set; }
        public double so_shiplot_pot { get; set; }
        public string in_locn_key { get; set; }
        public double so_shplot_recqt { get; set; }
        public short so_shplot_drctf { get; set; }
        public int so_shiplot_upcnt { get; set; }
    }
}
