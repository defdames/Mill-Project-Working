using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class s1_report_card_owners
    {
        public s1_report_card_owners()
        {
            this.s1_report_card_master = new List<s1_report_card_master>();
        }

        public string owner { get; set; }
        public string salesman { get; set; }
        public virtual ICollection<s1_report_card_master> s1_report_card_master { get; set; }
    }
}
