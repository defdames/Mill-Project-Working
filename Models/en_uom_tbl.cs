using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_uom_tbl
    {
        public string en_uom_key { get; set; }
        public string en_uom_desc { get; set; }
        public short en_uom_type { get; set; }
        public string en_uom_fmt { get; set; }
        public short en_uom_round { get; set; }
        public Nullable<short> en_uom_rsvfg { get; set; }
        public int en_uom_upcnt { get; set; }
    }
}
