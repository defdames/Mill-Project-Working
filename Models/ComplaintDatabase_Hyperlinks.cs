using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ComplaintDatabase_Hyperlinks
    {
        public int ID { get; set; }
        public Nullable<int> ComplaintID { get; set; }
        public string Link_Description { get; set; }
        public string Hyperlink { get; set; }
    }
}
