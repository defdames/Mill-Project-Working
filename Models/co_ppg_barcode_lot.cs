using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class co_ppg_barcode_lot
    {
        public string Product { get; set; }
        public string OrderNo { get; set; }
        public string LineNbr { get; set; }
        public string Whse { get; set; }
        public string ProdDesc { get; set; }
        public string hdrCustPartNo { get; set; }
        public string CustPartNo { get; set; }
        public string bcCustPart { get; set; }
        public string LotNbr { get; set; }
        public string NofN { get; set; }
        public string LotNo { get; set; }
        public string bcLotNo { get; set; }
        public string HdrDtlKey { get; set; }
        public Nullable<double> GrossWt { get; set; }
        public string NetWt { get; set; }
        public string bcNetWt { get; set; }
        public Nullable<double> TareWt { get; set; }
        public string ReInspectDate { get; set; }
        public Nullable<System.DateTime> MfgDate { get; set; }
        public string ContType { get; set; }
        public string bcContType { get; set; }
        public Nullable<int> LocId { get; set; }
        public string SerialNo { get; set; }
        public string bcSerial { get; set; }
        public string Health { get; set; }
        public string Flammability { get; set; }
        public string Reactivity { get; set; }
        public string PersProt { get; set; }
        public string SHISText { get; set; }
        public string SHISText2 { get; set; }
        public string SHISText3 { get; set; }
        public string NewSeqno { get; set; }
        public Nullable<short> IncrBy { get; set; }
    }
}
