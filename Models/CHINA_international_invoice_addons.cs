using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_international_invoice_addons
    {
        public string ProdKey { get; set; }
        public string ProdDesc { get; set; }
        public Nullable<int> ShipType { get; set; }
        public string so_hdr_key { get; set; }
        public double ExtPrice { get; set; }
        public string gl_cmp_key { get; set; }
        public double VATAMT { get; set; }
        public double vatrate { get; set; }
    }
}
