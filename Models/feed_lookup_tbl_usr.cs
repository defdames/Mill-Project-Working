using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class feed_lookup_tbl_usr
    {
        public string feed { get; set; }
        public string where_used { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
    }
}
