using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_bill_ext
    {
        public string en_bill_key { get; set; }
        public string en_country_id { get; set; }
        public string aextended_bill_name { get; set; }
        public string city { get; set; }
        public string zcontactname { get; set; }
        public string zinternetaddress { get; set; }
        public string xref_bill_to { get; set; }
        public int en_bill_upcnt { get; set; }
    }
}
