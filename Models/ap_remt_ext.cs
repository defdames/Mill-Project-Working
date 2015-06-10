using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_remt_ext
    {
        public string gl_cmp_key { get; set; }
        public string ap_remt_key { get; set; }
        public string bank { get; set; }
        public string bank_sort { get; set; }
        public int ap_remt_upcnt { get; set; }
        public string companytaxid { get; set; }
        public string recvbankroutnumber { get; set; }
        public string recvbankaccountnumber { get; set; }
        public string individualname { get; set; }
    }
}
