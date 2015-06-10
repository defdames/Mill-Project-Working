using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class channelpartner_detail_sales
    {
        public string channel_partner_code { get; set; }
        public string customer_code { get; set; }
        public string invoice_number { get; set; }
        public System.DateTime invoice_date { get; set; }
        public string product_code { get; set; }
        public string lot_number { get; set; }
        public double units_sold { get; set; }
        public string uom { get; set; }
        public double dollars { get; set; }
        public string rebate { get; set; }
        public string approved { get; set; }
        public string uploaded { get; set; }
        public int id { get; set; }
    }
}
