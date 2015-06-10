using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_ivhdr_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_ivhdr_key { get; set; }
        public string vessel { get; set; }
        public string markings { get; set; }
        public string shipping_dates { get; set; }
        public string airway_bill_voy { get; set; }
        public string destination_cntry { get; set; }
        public string ports_from_to { get; set; }
        public int ar_ivhdr_upcnt { get; set; }
        public string ar_ivhdr_satproc { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_satpdt { get; set; }
        public string ar_ivhdr_einvstatusmsg { get; set; }
        public Nullable<int> ar_ivhdr_folio { get; set; }
        public string ar_ivhdr_vat { get; set; }
    }
}
