using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class EHS_corrective_action_tbl_usr
    {
        public decimal Incident_no { get; set; }
        public string Company { get; set; }
        public int CA_dtl_key { get; set; }
        public string Corrective_action { get; set; }
        public string Cause_addressed { get; set; }
        public string Responsible_person { get; set; }
        public System.DateTime Target_date { get; set; }
        public Nullable<System.DateTime> Completion_date { get; set; }
    }
}
