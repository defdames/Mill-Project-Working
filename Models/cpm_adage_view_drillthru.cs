using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class cpm_adage_view_drillthru
    {
        public string company { get; set; }
        public string account { get; set; }
        public short year { get; set; }
        public string period { get; set; }
        public int version { get; set; }
        public string gaap_adj { get; set; }
        public string department { get; set; }
        public Nullable<double> amount { get; set; }
        public string gl_acct_key { get; set; }
    }
}
