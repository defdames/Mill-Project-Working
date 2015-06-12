using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_vchr_ext
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ap_vchr_type { get; set; }
        public string ap_vchr_key { get; set; }
        public string vendorinvoice { get; set; }
        public string vessel { get; set; }
        public Nullable<System.DateTime> vetd { get; set; }
        public Nullable<System.DateTime> veta { get; set; }
        public int ap_vchr_upcnt { get; set; }
    }
}
