using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class basf_barcode_shipping_label_New
    {
        public string Product { get; set; }
        public string OrderNo { get; set; }
        public string LineNbr { get; set; }
        public string Whse { get; set; }
        public string ProdDesc { get; set; }
        public string hdrCustPartNo { get; set; }
        public string CustPartNo { get; set; }
        public string bcCustPart { get; set; }
        public string CustPONo { get; set; }
        public string bcPONo { get; set; }
        public string LotNbr { get; set; }
        public string NofN { get; set; }
        public string LotNo { get; set; }
        public string bcLotNo { get; set; }
        public string HdrDtlKey { get; set; }
        public string UOM { get; set; }
        public Nullable<double> GrossWt { get; set; }
        public string NetWt { get; set; }
        public string bcNetWt { get; set; }
        public Nullable<double> TareWt { get; set; }
        public Nullable<double> nTareWt { get; set; }
        public string ReInspectDate { get; set; }
        public string MfgDate { get; set; }
        public string bcMfgDate { get; set; }
        public string ContType { get; set; }
        public string bcContType { get; set; }
        public Nullable<int> LocId { get; set; }
        public string SerialNo { get; set; }
        public string bcSerial { get; set; }
        public string Health { get; set; }
        public string Flammability { get; set; }
        public string Reactivity { get; set; }
        public string NewSeqno { get; set; }
        public Nullable<short> IncrBy { get; set; }
        public string gl_cmp_key { get; set; }
        public string bcNetWtKG { get; set; }
        public string NetWtKG { get; set; }
    }
}
