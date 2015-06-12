using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class araging_debitamt
    {
        public string invkey { get; set; }
        public string gl_cmp_key { get; set; }
        public string ar_dbcrm_stats { get; set; }
        public Nullable<decimal> debitamt { get; set; }
        public Nullable<decimal> debitamtf { get; set; }
    }
}
