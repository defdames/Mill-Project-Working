using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class released_orders_tbl_usr
    {
        public string OrderNo { get; set; }
        public short LineNbr { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }
        public string Product { get; set; }
        public Nullable<double> Demand_Qty { get; set; }
        public Nullable<System.DateTime> Promise_Date { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Released_Date { get; set; }
        public Nullable<double> Released_Qty { get; set; }
        public string Released_Remarks { get; set; }
        public Nullable<System.DateTime> DateTime_Stamp { get; set; }
        public Nullable<double> Alcqt { get; set; }
    }
}
