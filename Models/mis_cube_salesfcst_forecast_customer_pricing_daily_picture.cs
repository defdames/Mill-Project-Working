using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_forecast_customer_pricing_daily_picture
    {
        public string gl_cmp_key { get; set; }
        public string en_ship_key { get; set; }
        public string pc_bsprdt_prod { get; set; }
        public string pc_bsprdt_uom { get; set; }
        public Nullable<decimal> pc_bsprdt_price { get; set; }
        public string gl_crncy_key { get; set; }
        public int priority { get; set; }
    }
}
