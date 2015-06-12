using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class activity_by_whse_vw1
    {
        public string ItemKey { get; set; }
        public string Whse { get; set; }
        public string WhseItem { get; set; }
        public string Commodity { get; set; }
        public Nullable<double> BOH { get; set; }
        public Nullable<double> Production { get; set; }
        public Nullable<double> ProdReceipts { get; set; }
        public Nullable<double> ProdIssues { get; set; }
        public Nullable<double> InvAdj { get; set; }
        public Nullable<double> PO { get; set; }
        public Nullable<double> WhseXfers { get; set; }
        public short PdMo { get; set; }
        public short PdYr { get; set; }
        public Nullable<double> EOH { get; set; }
    }
}
