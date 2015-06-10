using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_type_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_type_key { get; set; }
        public string gl_type_desc { get; set; }
        public int gl_type_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_type_chgdt { get; set; }
        public System.DateTime gl_type_crtdt { get; set; }
    }
}
