using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class china_order_details
    {
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string en_mktseg_key { get; set; }
        public string en_application_key { get; set; }
        public string en_enduser_key { get; set; }
        public virtual china_application china_application { get; set; }
        public virtual china_enduser china_enduser { get; set; }
        public virtual china_market china_market { get; set; }
    }
}
