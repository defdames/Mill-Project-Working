using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class commission_transaction_invoice_view
    {
        public string gl_cmp_key { get; set; }
        public string so_salsm_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public double so_comtr_soamt { get; set; }
        public double so_comtr_cmval { get; set; }
        public double so_comtr_booked { get; set; }
        public System.DateTime so_comtr_trndt { get; set; }
        public string in_prod_key { get; set; }
        public string in_prod_desc { get; set; }
        public double so_shpqt_qty { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_bill_name { get; set; }
        public string so_salsm_name { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string ar_terms_key { get; set; }
        public string ar_terms_desc { get; set; }
    }
}
