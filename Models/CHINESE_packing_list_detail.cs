using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINESE_packing_list_detail
    {
        public string so_hdr_key { get; set; }
        public string so_brnch_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string ar_ship_key { get; set; }
        public string ar_bill_key { get; set; }
        public string en_cust_key { get; set; }
        public System.DateTime so_hdr_crtdt { get; set; }
        public string so_hdr_cpono { get; set; }
        public string so_hdr_ref { get; set; }
        public string so_dtl_stats { get; set; }
        public short so_dtl_key { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
        public string so_dtl_fobds { get; set; }
        public double so_dtl_ordqt { get; set; }
        public string so_dtl_cprtn { get; set; }
        public string so_dtl_cpono { get; set; }
        public string in_prod_key { get; set; }
        public string in_prod_desc { get; set; }
        public double so_dtl_shpqt { get; set; }
        public string so_dtl_shpws { get; set; }
        public string en_frgt_key { get; set; }
        public string en_carr_key { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public string im_pack_key { get; set; }
        public string DtlInst { get; set; }
        public string LotKey { get; set; }
        public string InsNo { get; set; }
        public string Remarks { get; set; }
        public string ShipName { get; set; }
        public string ShipLine1 { get; set; }
        public string ShipLine2 { get; set; }
        public string ShipLine3 { get; set; }
        public string ShipCSZ { get; set; }
        public string ShipTel { get; set; }
        public string SoldName { get; set; }
        public string SoldLine1 { get; set; }
        public string SoldLine2 { get; set; }
        public string SoldLine3 { get; set; }
        public string SoldCSZ { get; set; }
        public string UoM { get; set; }
        public Nullable<double> NoPkg { get; set; }
        public Nullable<double> NoPkgSAP { get; set; }
        public Nullable<double> OrdrQty { get; set; }
        public Nullable<double> ShipQty { get; set; }
        public string LineNbr { get; set; }
        public string TermDesc { get; set; }
        public string CarrDesc { get; set; }
        public string so_hdr_booknum { get; set; }
        public string ex_ship_container { get; set; }
        public string en_mode_key { get; set; }
        public string en_frtitem_key { get; set; }
        public Nullable<double> GrossWt { get; set; }
        public string en_cntry_key { get; set; }
        public Nullable<short> en_hazard_flg { get; set; }
    }
}
