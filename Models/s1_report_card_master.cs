using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class s1_report_card_master
    {
        public string region { get; set; }
        public string customer { get; set; }
        public string owner { get; set; }
        public string gl_cmp_key { get; set; }
        public virtual s1_report_card_owners s1_report_card_owners { get; set; }
        public virtual s1_report_card_regions s1_report_card_regions { get; set; }
    }
}
