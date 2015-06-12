using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PDAhdr
    {
        public int RequestNo { get; set; }
        public string RequestedBy { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string Market { get; set; }
        public string Currency { get; set; }
        public string RebateProgram { get; set; }
        public string PaymentTerms { get; set; }
        public string FreightTerms { get; set; }
        public string Customer { get; set; }
        public string CustomerName { get; set; }
        public string ShipTo { get; set; }
        public string ShipToName { get; set; }
        public string BillTo { get; set; }
        public string BillToName { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToCountry { get; set; }
        public string MultiNational { get; set; }
        public string Zone { get; set; }
        public string FreightPayment { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string Entity { get; set; }
        public string CPCName { get; set; }
        public string CPCCity { get; set; }
        public string CPCState { get; set; }
        public string CPCCountry { get; set; }
    }
}
