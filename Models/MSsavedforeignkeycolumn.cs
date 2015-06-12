using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsavedforeignkeycolumn
    {
        public string program_name { get; set; }
        public string constraint_name { get; set; }
        public string parent_schema { get; set; }
        public int constraint_column_id { get; set; }
        public string referencing_column_name { get; set; }
        public string referenced_column_name { get; set; }
        public System.DateTime timestamp { get; set; }
    }
}
