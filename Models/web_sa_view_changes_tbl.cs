using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class web_sa_view_changes_tbl
    {
        public System.DateTime CreateDate { get; set; }
        public string ViewName { get; set; }
        public string ViewCode { get; set; }
        public string Initials { get; set; }
        public string ChangeDescription { get; set; }
        public byte[] LargeText { get; set; }
    }
}
