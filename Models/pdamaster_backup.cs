using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pdamaster_backup
    {
        public string ApprovedBy { get; set; }
        public System.DateTime ApprovedDate { get; set; }
        public string Market { get; set; }
        public string ProductCode { get; set; }
        public string Currency { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal NewRequested_Price { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string FreightTerms { get; set; }
        public string Competitor { get; set; }
        public string CompetitiveProduct { get; set; }
        public decimal CompetitivePrice { get; set; }
        public string Customer { get; set; }
        public string ShipTo { get; set; }
        public string ShipToName { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string BillTo { get; set; }
        public string BillToName { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToCountry { get; set; }
        public string Entity { get; set; }
        public string Break_Pallet { get; set; }
        public string Freight_Allowance { get; set; }
        public string Repack { get; set; }
        public decimal ListPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public string MinimumInvoice { get; set; }
        public string StdPack { get; set; }
        public string AltPack { get; set; }
        public string CPCName { get; set; }
        public string CPCCity { get; set; }
        public string CPCState { get; set; }
        public string CPCCountry { get; set; }
    }
}
