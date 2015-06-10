using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINESE_bill_invoice
    {
        public string ar_ivhdr_key { get; set; }
        public Nullable<System.DateTime> tran_date_key { get; set; }
        public System.DateTime ar_ivhdr_duedt { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_ship_key { get; set; }
        public string so_hdr_cpono { get; set; }
        public string so_hdr_key { get; set; }
        public string en_cust_key { get; set; }
        public double ar_ivhdr_ivblc { get; set; }
        public string ProdKey { get; set; }
        public string ProdDesc { get; set; }
        public double so_dtl_unitc { get; set; }
        public double ar_ivdtl_extdc { get; set; }
        public int ar_ivdtl_key { get; set; }
        public Nullable<int> dtlkey { get; set; }
        public double ar_ivdtl_invqtpuom { get; set; }
        public string so_ship_key { get; set; }
        public string en_whs_key { get; set; }
        public string ar_ivhdr_type { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<short> so_dtl_key { get; set; }
        public string FOB { get; set; }
        public Nullable<double> so_dtl_ordqt { get; set; }
        public string so_dtl_cprtn { get; set; }
        public string so_dtl_cpono { get; set; }
        public Nullable<double> so_dtl_shpqt { get; set; }
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
        public Nullable<double> OrdrQty { get; set; }
        public Nullable<double> ShipQty { get; set; }
        public Nullable<double> UnitCost { get; set; }
        public Nullable<double> ExtPrice { get; set; }
        public string DtlInst { get; set; }
        public string TermDesc { get; set; }
        public string IntNbr { get; set; }
        public string e { get; set; }
        public string gl_cmp_key { get; set; }
        public string ar_tax_key { get; set; }
        public Nullable<double> ar_tax_amtcf { get; set; }
        public string ex_ship_mark1 { get; set; }
        public string ex_ship_mark2 { get; set; }
        public string ex_ship_mark3 { get; set; }
        public string ex_ship_mark4 { get; set; }
        public string ex_ship_mark5 { get; set; }
        public string ex_ship_mark6 { get; set; }
        public string vessel { get; set; }
        public string markings { get; set; }
        public string shipping_dates { get; set; }
        public string airway_bill_voy { get; set; }
        public string destination_cntry { get; set; }
        public string ports_from_to { get; set; }
        public Nullable<int> so_prod_shipf { get; set; }
        public string en_mode_key { get; set; }
        public Nullable<double> erate { get; set; }
        public string agent { get; set; }
        public double VATAMT { get; set; }
        public double DVATAMT { get; set; }
        public string so_dtl_shtvatregno { get; set; }
        public string gl_crncy_key { get; set; }
        public double gl_vatrate_pct { get; set; }
    }
}
