using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_SALES_COMMISIONS
    {
        public string GL_CMP_KEY { get; set; }
        public string SO_HDR_KEY { get; set; }
        public short SO_DTL_KEY { get; set; }
        public double SO_COMTR_CMVAL { get; set; }
        public double SO_COMTR_BOOKED { get; set; }
        public string in_prod_key { get; set; }
        public string ar_ivhdr_Key { get; set; }
    }
}
