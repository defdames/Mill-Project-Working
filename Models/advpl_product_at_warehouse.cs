using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class advpl_product_at_warehouse
    {
        public string Code { get; set; }
        public double Stock_Cover { get; set; }
        public string Description { get; set; }
        public string Commodity { get; set; }
        public string Planning_Family { get; set; }
        public int IsPurchased { get; set; }
        public Nullable<decimal> stdcost { get; set; }
        public string company { get; set; }
        public int priorityfactor { get; set; }
    }
}
