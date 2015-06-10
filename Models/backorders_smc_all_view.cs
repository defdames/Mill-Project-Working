using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class backorders_smc_all_view
    {
        public string order_no_ { get; set; }
        public string customer { get; set; }
        public string product { get; set; }
        public string en_prod_desc { get; set; }
        public Nullable<double> openqty { get; set; }
        public Nullable<double> opendollars { get; set; }
        public System.DateTime orderdate { get; set; }
        public System.DateTime so_dtl_reqdt { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public Nullable<int> datedifference { get; set; }
    }
}
