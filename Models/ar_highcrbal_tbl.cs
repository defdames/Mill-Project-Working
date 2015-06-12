using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_highcrbal_tbl
    {
        public string ar_entity_key { get; set; }
        public short ar_entity_type { get; set; }
        public string gl_cmp_key { get; set; }
        public int ar_perod_seqno { get; set; }
        public Nullable<double> ar_highcrbal_bal { get; set; }
        public Nullable<double> ar_highcrbal_exp { get; set; }
        public int ar_highcrbal_upcnt { get; set; }
    }
}
