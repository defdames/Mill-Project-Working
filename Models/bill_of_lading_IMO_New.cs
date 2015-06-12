using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class bill_of_lading_IMO_New
    {
        public string so_load_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public Nullable<System.DateTime> so_ship_date { get; set; }
        public string ar_ship_key { get; set; }
        public string so_hdr_cpono { get; set; }
        public string ar_bill_key { get; set; }
        public string Remark { get; set; }
        public string FrgtKey { get; set; }
        public string WhsName { get; set; }
        public string WhsLine1 { get; set; }
        public string WhsLine2 { get; set; }
        public string WhsCSZ { get; set; }
        public string ShipName { get; set; }
        public string ShipLine1 { get; set; }
        public string ShipLine2 { get; set; }
        public string ShipLine3 { get; set; }
        public string ShipCSZ { get; set; }
        public string Phone { get; set; }
        public string SoldName { get; set; }
        public string SoldLine1 { get; set; }
        public string SoldLine2 { get; set; }
        public string SoldLine3 { get; set; }
        public string SoldCSZ { get; set; }
        public string en_carr_scac { get; set; }
        public string GLAcct { get; set; }
        public Nullable<double> ShipWt { get; set; }
        public Nullable<decimal> netwt { get; set; }
        public Nullable<double> NoPkg { get; set; }
        public string bol_desc1 { get; set; }
        public string bol_desc2 { get; set; }
        public string bol_desc3 { get; set; }
        public string bol_desc4 { get; set; }
        public string bol_desc5 { get; set; }
        public string en_frtitem_key { get; set; }
        public string HM { get; set; }
        public string CarrDesc { get; set; }
        public string im_adres_cntry { get; set; }
        public string en_sltyp_key { get; set; }
        public string in_whs_key { get; set; }
        public string so_hdr_booknum { get; set; }
        public string ex_ship_container { get; set; }
        public string xvessel_name { get; set; }
        public string xvoyage_number { get; set; }
        public string xwport_of_loading { get; set; }
        public string so_hdr_port_discharge { get; set; }
        public string packdesc { get; set; }
        public string gl_cmp_key { get; set; }
        public string en_mode_key { get; set; }
        public Nullable<int> so_hdr_pallets { get; set; }
        public string so_dtl_stats { get; set; }
        public string IM_PACK_KEY { get; set; }
        public string so_dtlpr_prcuom { get; set; }
        public string so_prod_wtuom { get; set; }
    }
}
