using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class distdb_cprdprof_tbl_usr
    {
        public string customer { get; set; }
        public string location { get; set; }
        public string grade { get; set; }
        public string status { get; set; }
        public string userid { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
    }
}
