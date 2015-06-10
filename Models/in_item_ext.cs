using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_item_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_item_key { get; set; }
        public string health { get; set; }
        public string iflammability { get; set; }
        public string reaction { get; set; }
        public string xref_item_name { get; set; }
        public int in_item_upcnt { get; set; }
    }
}
