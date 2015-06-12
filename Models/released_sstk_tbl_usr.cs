using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class released_sstk_tbl_usr
    {
        public short item_sstk_id { get; set; }
        public string whse { get; set; }
        public string item { get; set; }
        public string pack { get; set; }
        public Nullable<System.DateTime> released_date { get; set; }
        public Nullable<double> released_qty { get; set; }
        public string released_remarks { get; set; }
        public string transfer_id { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
    }
}
