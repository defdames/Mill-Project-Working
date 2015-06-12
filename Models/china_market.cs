using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class china_market
    {
        public china_market()
        {
            this.china_order_details = new List<china_order_details>();
        }

        public string china_market1 { get; set; }
        public virtual ICollection<china_order_details> china_order_details { get; set; }
    }
}
