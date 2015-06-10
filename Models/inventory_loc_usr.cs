using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class inventory_loc_usr
    {
        public System.DateTime ldate { get; set; }
        public string item { get; set; }
        public string pack { get; set; }
        public string lot { get; set; }
        public string loc { get; set; }
        public string iuser { get; set; }
        public string usedwhere { get; set; }
        public string remarks { get; set; }
        public Nullable<short> amtused { get; set; }
        public string usedfrom { get; set; }
    }
}
