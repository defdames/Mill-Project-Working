using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_jlhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public int gl_jlnum_key { get; set; }
        public System.DateTime gl_jlhdr_date { get; set; }
        public string gl_jlhdr_desc { get; set; }
        public string gl_jlhdr_refno { get; set; }
        public short gl_jlnum_type { get; set; }
        public string gl_jlhdr_crncy { get; set; }
        public string gl_jlhdr_status { get; set; }
        public int gl_jlhdr_revers { get; set; }
        public int gl_tran_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_jlhdr_chgdt { get; set; }
        public System.DateTime gl_jlhdr_crtdt { get; set; }
        public int gl_jlhdr_upcnt { get; set; }
        public Nullable<System.DateTime> gl_jlhdr_asofdt { get; set; }
        public short gl_jlhdr_intcmpf { get; set; }
        public int gl_journaltype_id { get; set; }
    }
}
