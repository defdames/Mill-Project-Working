using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINESE_Purchase_Order_child
    {
        public System.DateTime Date_ordrd { get; set; }
        public System.DateTime Date_reqrd { get; set; }
        public string dtlHdrkey { get; set; }
        public short Detlkey { get; set; }
        public string PO_key { get; set; }
        public string ItemKey { get; set; }
        public string FOb_dtl { get; set; }
        public double Qty_ordrd { get; set; }
        public string Descr { get; set; }
        public string im_pack_key { get; set; }
        public double Unit_prce { get; set; }
        public string Wh_Key { get; set; }
        public string Desctext { get; set; }
        public Nullable<short> Desc_Key { get; set; }
        public string hdr_key { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
