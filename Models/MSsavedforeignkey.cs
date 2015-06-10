using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsavedforeignkey
    {
        public string program_name { get; set; }
        public string constraint_name { get; set; }
        public string parent_schema { get; set; }
        public string parent_name { get; set; }
        public string referenced_object_schema { get; set; }
        public string referenced_object_name { get; set; }
        public bool is_disabled { get; set; }
        public bool is_not_for_replication { get; set; }
        public bool is_not_trusted { get; set; }
        public byte delete_referential_action { get; set; }
        public byte update_referential_action { get; set; }
        public System.DateTime timestamp { get; set; }
    }
}
