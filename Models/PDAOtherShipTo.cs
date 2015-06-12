using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PDAOtherShipTo
    {
        public string entity { get; set; }
        public string customer { get; set; }
        public string billto { get; set; }
        public string othershipto { get; set; }
        public string ShipToName { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
    }
}
