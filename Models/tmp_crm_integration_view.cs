using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tmp_crm_integration_view
    {
        public string GlobalName { get; set; }
        public string Region { get; set; }
        public string Company { get; set; }
        public string ShipName { get; set; }
        public int TransactionShipKey { get; set; }
        public string TransactionAddressLine1 { get; set; }
        public string TransactionAddressLine2 { get; set; }
        public string TransactionAddressLine3 { get; set; }
        public string TransactionAddressCity { get; set; }
        public string TransactionAddressState { get; set; }
        public string TransactionAddressCountry { get; set; }
        public string TransactionAddressZip { get; set; }
        public string TransactionTelephone { get; set; }
        public string TransactionFax { get; set; }
        public string SampleShipKey { get; set; }
        public string SampleAddressLine1 { get; set; }
        public string SampleAddressLine2 { get; set; }
        public string SampleAddressLine3 { get; set; }
        public string SampleAddressCity { get; set; }
        public string SampleAddressState { get; set; }
        public string SampleAddressCountry { get; set; }
        public string SampleAddressZip { get; set; }
        public string SampleTelephone { get; set; }
        public string SampleFax { get; set; }
        public string SalesForceID { get; set; }
        public string owner { get; set; }
        public int ownerid { get; set; }
        public Nullable<int> parentid { get; set; }
    }
}
