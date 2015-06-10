using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_purchase_orders
    {
        public string Code { get; set; }
        public System.DateTime reqDate { get; set; }
        public System.DateTime prmdate { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string company { get; set; }
    }
}
