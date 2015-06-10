using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class china_enduser
    {
        public china_enduser()
        {
            this.china_order_details = new List<china_order_details>();
        }

        public string china_enduser1 { get; set; }
        public virtual ICollection<china_order_details> china_order_details { get; set; }
    }
}
