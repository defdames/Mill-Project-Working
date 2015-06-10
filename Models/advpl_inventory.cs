using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_inventory
    {
        public string Code { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string company { get; set; }
    }
}
