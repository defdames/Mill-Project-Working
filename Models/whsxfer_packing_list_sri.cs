using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class whsxfer_packing_list_sri
    {
        public string in_wthdr_key { get; set; }
        public System.DateTime in_wthdr_crtdt { get; set; }
        public string in_wthdr_towhs { get; set; }
        public string in_wthdr_frwhs { get; set; }
        public int in_wtdtl_stat { get; set; }
        public short in_wtdtl_key { get; set; }
        public System.DateTime in_wtdtl_shsdt { get; set; }
        public double in_wtdtl_reqqt { get; set; }
        public double in_wtdtl_shpqt { get; set; }
        public string in_desc { get; set; }
        public string ItemDesc { get; set; }
        public string in_item_key { get; set; }
        public string Item { get; set; }
        public string en_frtitem_key { get; set; }
        public string HdrKey { get; set; }
        public string LineRemark { get; set; }
        public string ItemKey { get; set; }
        public string LotKey { get; set; }
        public string InsNo { get; set; }
        public string Remarks { get; set; }
        public string FrWhsLine1 { get; set; }
        public string FrWhsLine2 { get; set; }
        public string FrWhsCSZ { get; set; }
        public string ToWhsLine1 { get; set; }
        public string ToWhsLine2 { get; set; }
        public string ToWhsCSZ { get; set; }
        public string UoM { get; set; }
        public double NoPkg { get; set; }
        public double OrdrQty { get; set; }
        public Nullable<double> ShipQty { get; set; }
        public string LineNbr { get; set; }
        public string CarrDesc { get; set; }
        public string fromname { get; set; }
        public string toname { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
