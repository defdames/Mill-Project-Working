using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pc_bsprdt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pc_bsprhd_key { get; set; }
        public short pc_bsprdt_ppcind { get; set; }
        public string pc_bsprdt_prod { get; set; }
        public string im_pack_key { get; set; }
        public short pc_bsprdt_key { get; set; }
        public double pc_bsprdt_price { get; set; }
        public string pc_bsprdt_uom { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_ordefdt { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_ordiadt { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_shpefdt { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_shpiadt { get; set; }
        public short pc_bsprdt_ordefff { get; set; }
        public short pc_bsprdt_shpefff { get; set; }
        public short pc_bsprdt_inact { get; set; }
        public short pc_bsprdt_reprchgf { get; set; }
    }
}
