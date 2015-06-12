using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class backorder_by_class
    {
        public string so_hdr_typec { get; set; }
        public string Order_No_ { get; set; }
        public string Customer { get; set; }
        public string Customer_Class { get; set; }
        public string Product { get; set; }
        public string Product_Class { get; set; }
        public Nullable<double> openqty { get; set; }
        public string so_dtl_stats { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
        public Nullable<System.DateTime> so_dtl_shpdt { get; set; }
        public int so_prod_shipf { get; set; }
        public short so_dtl_key { get; set; }
        public Nullable<double> opendollars { get; set; }
        public string EN_PROD_DESC { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public System.DateTime so_dtl_reqdt { get; set; }
        public string ITEMSTATUS { get; set; }
        public string IN_ABCC { get; set; }
        public Nullable<int> datedifference { get; set; }
        public string LineStatus { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_crncy_key { get; set; }
    }
}
