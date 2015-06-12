using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class distdb_cprdsales_tbl_usr_pemfix
    {
        public string customer { get; set; }
        public string location { get; set; }
        public string grade { get; set; }
        public string period_id { get; set; }
        public short period_yr { get; set; }
        public short period_mo { get; set; }
        public Nullable<double> pounds { get; set; }
        public Nullable<double> dollars { get; set; }
        public string userid { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
    }
}
