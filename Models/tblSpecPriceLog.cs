using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tblSpecPriceLog
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> EFFECT { get; set; }
        public string AGENT { get; set; }
        public string CUSTOMER { get; set; }
        public string LOCATION { get; set; }
        public string GRADE { get; set; }
        public string PRICE_LB_PACK { get; set; }
        public string QUANTITY { get; set; }
        public Nullable<System.DateTime> EXPIRES { get; set; }
        public string MS_MM { get; set; }
        public string COMMENTS { get; set; }
        public string AGENT_NAME { get; set; }
        public string COPIES { get; set; }
        public string MANAGER { get; set; }
        public string LINK_FIELD { get; set; }
        public string CONTRACT_NO { get; set; }
        public string CUSTOMER_NO { get; set; }
        public string CUSTOMER_LABEL { get; set; }
        public string LOCATION_LABEL { get; set; }
        public string AGREEMENT_ID { get; set; }
        public string AGREEMENT_DESCRIPTION { get; set; }
        public string PRODUCT_NO { get; set; }
        public string FIXED_BASED_PRICE { get; set; }
        public string ALLOW_PROMO { get; set; }
        public string SOLD_BILL_SHIP { get; set; }
        public string BREAKS { get; set; }
    }
}
