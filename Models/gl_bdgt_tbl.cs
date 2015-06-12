using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_bdgt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_bdgt_id { get; set; }
        public short gl_perod_year { get; set; }
        public string gl_bdgtwt_key { get; set; }
        public string gl_bdgt_desc { get; set; }
        public int gl_bdgt_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_bdgt_chgdt { get; set; }
        public System.DateTime gl_bdgt_crtdt { get; set; }
    }
}
