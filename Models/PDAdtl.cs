using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class PDAdtl
    {
        public int RequestNo { get; set; }
        public string entity { get; set; }
        public string ApprovedBy { get; set; }
        public string DeclinedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<System.DateTime> DeclinedDate { get; set; }
        public string ProductID { get; set; }
        public decimal ListPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal NewRequested_Price { get; set; }
        public int MinimumOrder_Quantity { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string Competitor { get; set; }
        public string CompetitiveProduct { get; set; }
        public decimal CompetitivePrice { get; set; }
        public string AdditionalInformation { get; set; }
        public string FreightSupport { get; set; }
        public string BreakPallet { get; set; }
        public string FreightAllowance { get; set; }
        public string Repack { get; set; }
        public string MinimumInvoice { get; set; }
        public string StdPack { get; set; }
        public string AltPack { get; set; }
        public string EstimatedAnnualVolume { get; set; }
    }
}
