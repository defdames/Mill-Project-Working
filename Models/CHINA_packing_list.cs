using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_packing_list
    {
        public string so_hdr_key { get; set; }
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
        public string im_pack_key { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public string DtlInst { get; set; }
        public string in_lot_key { get; set; }
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
        public Nullable<double> OrdrQty { get; set; }
        public Nullable<double> ShipQty { get; set; }
        public string LineNbr { get; set; }
        public string TermDesc { get; set; }
        public string CarrDesc { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string so_hdr_booknum { get; set; }
        public string ex_ship_container { get; set; }
        public string gl_cmp_key { get; set; }
        public string inv_whs { get; set; }
        public string in_whs_name { get; set; }
        public string in_whs_adr1 { get; set; }
        public string in_whs_adr2 { get; set; }
        public string whsline3 { get; set; }
        public string whsline4 { get; set; }
        public string EN_MODE_KEY { get; set; }
        public string ex_ship_mark1 { get; set; }
        public string ex_ship_mark2 { get; set; }
        public string ex_ship_mark3 { get; set; }
        public string ex_ship_mark4 { get; set; }
        public string ex_ship_mark5 { get; set; }
        public string ex_ship_mark6 { get; set; }
        public string so_hdr_instrux { get; set; }
        public Nullable<int> so_hdr_pallets { get; set; }
        public string so_hdr_spec_instrux { get; set; }
        public Nullable<double> im_pack_qty { get; set; }
        public Nullable<System.DateTime> so_hdr_reqdt { get; set; }
        public string xwport_of_loading { get; set; }
        public string so_hdr_port_discharge { get; set; }
        public Nullable<double> GrossWt { get; set; }
        public string porp { get; set; }
    }
}
