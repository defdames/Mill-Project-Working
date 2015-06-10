using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsavedforeignkeyextendedproperty
    {
        public string program_name { get; set; }
        public string constraint_name { get; set; }
        public string parent_schema { get; set; }
        public string property_name { get; set; }
        public System.DateTime timestamp { get; set; }
    }
}
