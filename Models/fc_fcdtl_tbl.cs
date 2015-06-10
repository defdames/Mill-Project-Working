using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class fc_fcdtl_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string fc_fcst_numbr { get; set; }
        public System.DateTime fc_fcdtl_strdt { get; set; }
        public string fc_fcdtl_bpkey { get; set; }
        public System.DateTime fc_fcdtl_enddt { get; set; }
        public double fc_fcdtl_qty { get; set; }
        public double fc_fcdtl_acqty { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public int fc_fcdtl_upcnt { get; set; }
    }
}
