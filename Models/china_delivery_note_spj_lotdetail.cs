using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class china_delivery_note_spj_lotdetail
    {
        public string gl_cmp_key { get; set; }
        public string so_load_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string in_lot_key { get; set; }
        public Nullable<double> ShpQty { get; set; }
        public string countryoforigin { get; set; }
        public Nullable<System.DateTime> en_lot_mfgdt { get; set; }
        public string ar_ship_key { get; set; }
    }
}
