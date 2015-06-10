using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class agent_shipto_vw
    {
        public string Shipto { get; set; }
        public string ShipName { get; set; }
        public string TargetAcct { get; set; }
        public string WhseAcct { get; set; }
        public string TopCustomerName { get; set; }
        public string Location { get; set; }
    }
}
