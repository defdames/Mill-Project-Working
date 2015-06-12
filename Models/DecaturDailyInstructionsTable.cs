using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class DecaturDailyInstructionsTable
    {
        public string System { get; set; }
        public string Instructions { get; set; }
        public string Grade { get; set; }
        public System.DateTime Date { get; set; }
        public string Supervisors { get; set; }
        public string Crew { get; set; }
    }
}
