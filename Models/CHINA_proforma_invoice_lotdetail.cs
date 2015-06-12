using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_proforma_invoice_lotdetail
    {
        public string gl_cmp_key { get; set; }
        public string INVNO { get; set; }
        public string SOHDR { get; set; }
        public short SODTL { get; set; }
        public string in_lot_key { get; set; }
        public Nullable<double> ShpQty { get; set; }
        public string countryoforigin { get; set; }
    }
}
