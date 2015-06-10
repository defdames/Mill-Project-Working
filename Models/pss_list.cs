using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pss_list
    {
        public int pss_id { get; set; }
        public string region { get; set; }
        public string production_plant { get; set; }
        public string shipkey { get; set; }
        public string en_prod_key { get; set; }
        public string en_lot_key { get; set; }
        public System.DateTime date_sent { get; set; }
        public string accept_reject { get; set; }
        public string reason_for_rejection { get; set; }
        public string tc_ref_no { get; set; }
        public string pss_requirement { get; set; }
        public string remarks { get; set; }
        public string user_entered { get; set; }
        public Nullable<System.DateTime> user_entered_date { get; set; }
        public string user_updated { get; set; }
        public Nullable<System.DateTime> user_updated_date { get; set; }
    }
}
