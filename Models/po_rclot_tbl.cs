using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_rclot_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_recpt_key { get; set; }
        public short po_dtl_key { get; set; }
        public string in_lot_key { get; set; }
        public double po_rclot_qty { get; set; }
        public double po_rclot_stkqt { get; set; }
        public double po_rclot_retqt { get; set; }
        public string po_rclot_cmnts { get; set; }
        public string po_rclot_vlot { get; set; }
        public double po_rclot_frghtcst { get; set; }
        public double po_rclot_matlcst { get; set; }
        public double po_rclot_othrcst { get; set; }
        public double po_rclot_reconqt { get; set; }
        public string in_locn_key { get; set; }
        public double po_rclot_flatcst { get; set; }
        public double po_rclot_afillqty { get; set; }
    }
}
