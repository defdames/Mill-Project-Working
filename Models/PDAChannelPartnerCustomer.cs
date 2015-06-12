using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PDAChannelPartnerCustomer
    {
        public string entity { get; set; }
        public string customer { get; set; }
        public string billto { get; set; }
        public string shipto { get; set; }
        public string CPCName { get; set; }
    }
}
