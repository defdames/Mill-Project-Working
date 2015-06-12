using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Sample_Recertifications_Hyperlinks
    {
        public int ID { get; set; }
        public Nullable<int> Request_Number { get; set; }
        public string Link_Description { get; set; }
        public string Hyperlink { get; set; }
    }
}
