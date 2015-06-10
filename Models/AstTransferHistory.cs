using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class AstTransferHistory
    {
        public int TransferHistoryId { get; set; }
        public string CompanyKey { get; set; }
        public string WarehouseKey { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string po_hdr_key { get; set; }
        public string po_recpt_key { get; set; }
        public string in_item_key { get; set; }
        public string Im_pack_key { get; set; }
        public Nullable<double> Qty { get; set; }
        public string in_locn_from { get; set; }
        public string in_locn_to { get; set; }
        public string en_lot_key { get; set; }
        public string Sa_user_key { get; set; }
        public Nullable<System.DateTime> transactiondate { get; set; }
        public Nullable<short> po_dtl_key { get; set; }
    }
}
