using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_vend_ext
    {
        public string en_vend_key { get; set; }
        public string vendor_name { get; set; }
        public string iso_certification { get; set; }
        public string xref_vendor_name { get; set; }
        public Nullable<System.DateTime> ins_cert_exp { get; set; }
        public int en_vend_upcnt { get; set; }
    }
}
