using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_PURCHASE_ORDER
    {
        public string Ven_itemID { get; set; }
        public string Ven_name { get; set; }
        public string Ven_key { get; set; }
        public string Po_num { get; set; }
        public string im_pack_key { get; set; }
        public string Remarks { get; set; }
        public string ConfVia { get; set; }
        public string ConfWith { get; set; }
        public Nullable<System.DateTime> ConfDt { get; set; }
        public string vend_nm { get; set; }
        public int ShiptoKey { get; set; }
        public string Shipname { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Line5 { get; set; }
        public string Line6 { get; set; }
        public string Line7 { get; set; }
        public string Line8 { get; set; }
        public System.DateTime Date_ordrd { get; set; }
        public System.DateTime Date_reqrd { get; set; }
        public int DtlType { get; set; }
        public short Detlkey { get; set; }
        public string ItemKey { get; set; }
        public string FOb_dtl { get; set; }
        public string EnItemKey { get; set; }
        public string EnItemDesc { get; set; }
        public string comm_Req { get; set; }
        public string UOM { get; set; }
        public string Trms { get; set; }
        public string FOB { get; set; }
        public string Carrier { get; set; }
        public string Carrier_Desc { get; set; }
        public string Proj_num { get; set; }
        public double Qty_ordrd { get; set; }
        public double Price_Qty { get; set; }
        public string Price_Uom { get; set; }
        public string Descr { get; set; }
        public Nullable<double> Unit_prce { get; set; }
        public string Dtlcomments { get; set; }
        public string Byr_Cde { get; set; }
        public int Stats_Code { get; set; }
        public string Whname { get; set; }
        public string Wh_Addr1 { get; set; }
        public string Wh_Key { get; set; }
        public string Wh_addr2 { get; set; }
        public string Wh_Postc { get; set; }
        public string Wh_City { get; set; }
        public string Wh_st { get; set; }
        public string Wh_cntry { get; set; }
        public string Buydesc { get; set; }
        public string Itm_key_itdsc { get; set; }
        public string Itm_desc { get; set; }
        public int Frt_Terms { get; set; }
        public System.DateTime po_hdr_orddt { get; set; }
        public System.DateTime po_hdr_reqdt { get; set; }
        public string gl_cmp_key { get; set; }
        public string direct_ship_name { get; set; }
        public string direct_ship_adr1 { get; set; }
        public string direct_ship_adr2 { get; set; }
        public string direct_ship_adr3 { get; set; }
        public string direct_ship_city { get; set; }
        public string direct_ship_state { get; set; }
        public string direct_ship_cntry { get; set; }
        public string direct_ship_zip { get; set; }
        public string direct_ship_no { get; set; }
        public int po_hdr_revno { get; set; }
        public double unit_price_foreign { get; set; }
        public string EN_SERVICE_KEY { get; set; }
        public string GL_CRNCY_KEY { get; set; }
        public string countertype { get; set; }
        public int po_dtl_stats { get; set; }
        public Nullable<System.DateTime> po_hdr_revdt { get; set; }
        public double GL_VATRATE_PCT { get; set; }
        public string VPRT { get; set; }
        public string VDESC { get; set; }
        public string PO_DTL_CMMTS { get; set; }
        public string requisition_number { get; set; }
        public string ap_remt_key { get; set; }
        public Nullable<double> fullprice { get; set; }
        public double po_dtl_vatcf { get; set; }
        public int LineOrder { get; set; }
    }
}
