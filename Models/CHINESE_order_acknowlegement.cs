using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINESE_order_acknowlegement
    {
        public Nullable<int> so_prod_shipf { get; set; }
        public Nullable<double> so_dtl_shpqt { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_ship_key { get; set; }
        public string so_hdr_key { get; set; }
        public string en_cust_key { get; set; }
        public string en_mode_key { get; set; }
        public string ProdKey { get; set; }
        public string ProdDesc { get; set; }
        public Nullable<double> so_dtl_ordqt { get; set; }
        public Nullable<double> UNITPRICE { get; set; }
        public string so_dtl_shpws { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<short> so_dtl_key { get; set; }
        public string FOB { get; set; }
        public string so_dtl_cprtn { get; set; }
        public string so_dtl_cpono { get; set; }
        public string en_frgt_key { get; set; }
        public string ShipVia { get; set; }
        public string ShipName { get; set; }
        public string ShipLine1 { get; set; }
        public string ShipLine2 { get; set; }
        public string ShipLine3 { get; set; }
        public string ShipCSZ { get; set; }
        public string SoldName { get; set; }
        public string SoldLine1 { get; set; }
        public string SoldLine2 { get; set; }
        public string SoldLine3 { get; set; }
        public string SoldCSZ { get; set; }
        public string UoM { get; set; }
        public string DtlInst { get; set; }
        public string TermDesc { get; set; }
        public string so_hdr_ref { get; set; }
        public Nullable<System.DateTime> so_dtl_prmdt { get; set; }
        public Nullable<System.DateTime> so_dtl_shsdt { get; set; }
        public string so_hdr_cont { get; set; }
        public Nullable<double> orderqty { get; set; }
        public Nullable<double> in_whitm_scst { get; set; }
        public string gl_cmp_key { get; set; }
        public string so_hdr_typec { get; set; }
        public string xwport_of_loading { get; set; }
        public string so_hdr_port_discharge { get; set; }
        public string zord_ack { get; set; }
        public string so_dtl_instrux { get; set; }
        public string hdrcustpo { get; set; }
        public Nullable<double> gl_vatrate_pct { get; set; }
        public Nullable<double> so_dtlpr_vatcf { get; set; }
        public string gl_crncy_key { get; set; }
    }
}
