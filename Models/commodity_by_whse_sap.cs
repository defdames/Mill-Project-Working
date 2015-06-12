using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class commodity_by_whse_sap
    {
        public string ItemKey { get; set; }
        public string PackKey { get; set; }
        public Nullable<double> lbsqty { get; set; }
        public Nullable<double> kgsqty { get; set; }
        public short PdMo { get; set; }
        public short PdYr { get; set; }
        public string Commodity { get; set; }
        public string GLAcct { get; set; }
        public string ClassKey { get; set; }
        public string in_whs_key { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
