using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_class_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_class_key { get; set; }
        public string gl_class_desc { get; set; }
        public int gl_class_upcnt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_class_chgdt { get; set; }
        public System.DateTime gl_class_crtdt { get; set; }
    }
}
