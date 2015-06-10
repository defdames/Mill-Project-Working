using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_processes
    {
        public string Process_ID { get; set; }
        public string System_ID { get; set; }
        public Nullable<double> Rate { get; set; }
        public int batch_size { get; set; }
        public string company { get; set; }
    }
}
