using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_processes_system_hours
    {
        public string company { get; set; }
        public string systemid { get; set; }
        public Nullable<System.DateTime> bucket { get; set; }
        public long maxhours { get; set; }
    }
}
