using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Capital_Purchases
    {
        public string Ven_name { get; set; }
        public string Ven_key { get; set; }
        public string Po_num { get; set; }
        public Nullable<int> WhsCnt { get; set; }
        public string im_pack_key { get; set; }
        public string Remarks { get; set; }
        public string ConfVia { get; set; }
        public string vend_nm { get; set; }
        public int ShiptoKey { get; set; }
        public string Shipname { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string CityStateZip { get; set; }
        public string Country { get; set; }
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
        public string Proj_num { get; set; }
        public double Qty_ordrd { get; set; }
        public double Price_Qty { get; set; }
        public string Price_Uom { get; set; }
        public string Descr { get; set; }
        public double Unit_prce { get; set; }
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
        public Nullable<double> pototal { get; set; }
    }
}
