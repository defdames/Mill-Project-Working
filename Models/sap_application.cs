using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sap_application
    {
        public sap_application()
        {
            this.sap_order_details = new List<sap_order_details>();
        }

        public string sap_application1 { get; set; }
        public virtual ICollection<sap_order_details> sap_order_details { get; set; }
    }
}
