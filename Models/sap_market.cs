using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sap_market
    {
        public sap_market()
        {
            this.sap_order_details = new List<sap_order_details>();
        }

        public string sap_market1 { get; set; }
        public virtual ICollection<sap_order_details> sap_order_details { get; set; }
    }
}
