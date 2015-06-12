using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINESE_misc_invoice
    {
        public string ar_ivhdr_key { get; set; }
        public System.DateTime tran_date_key { get; set; }
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
        public string ar_tax_key { get; set; }
        public double ar_tax_amtc { get; set; }
        public string ar_ivhdr_type { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string SoldName { get; set; }
        public string SoldLine1 { get; set; }
        public string SoldLine2 { get; set; }
        public string SoldLine3 { get; set; }
        public string SoldCSZ { get; set; }
        public string ShipName { get; set; }
        public string ShipLine1 { get; set; }
        public string ShipLine2 { get; set; }
        public string ShipLine3 { get; set; }
        public string ShipCSZ { get; set; }
        public string UoM { get; set; }
        public string OrdrQty { get; set; }
        public string ShipQty { get; set; }
        public double ar_ivdtl_eadbasecf { get; set; }
        public double UnitCost { get; set; }
        public double ExtPrice { get; set; }
        public string TermDesc { get; set; }
        public string gl_cmp_key { get; set; }
        public string VatCode { get; set; }
        public double VatRate { get; set; }
        public double VatAmt { get; set; }
    }
}
