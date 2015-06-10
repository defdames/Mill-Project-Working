using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class basf_dirt_check_audit_view
    {
        public string gl_cmp_key { get; set; }
        public string so_hdr_Key { get; set; }
        public short so_dtl_key { get; set; }
        public string in_prod_key { get; set; }
        public string in_prod_desc { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
        public string in_lot_key { get; set; }
    }
}
