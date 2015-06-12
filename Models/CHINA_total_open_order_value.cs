using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_total_open_order_value
    {
        public string so_hdr_key { get; set; }
        public string hold_msg { get; set; }
        public string ar_ship_key { get; set; }
        public string ar_bill_key { get; set; }
        public int en_prod_shipf { get; set; }
        public Nullable<double> open_order_value { get; set; }
        public Nullable<double> open_order_qty { get; set; }
        public Nullable<double> open_order_cost { get; set; }
        public string sa_created_by { get; set; }
        public string gl_cmp_key { get; set; }
        public System.DateTime so_hdr_crtdt { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
    }
}
