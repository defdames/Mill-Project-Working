using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class buyer_activity_summary
    {
        public string po_hdr_key { get; set; }
        public string in_buyc { get; set; }
        public System.DateTime po_hdr_orddt { get; set; }
        public Nullable<double> dollars { get; set; }
    }
}
