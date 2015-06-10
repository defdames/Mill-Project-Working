using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class IC_PO_RECEIPT_DATES
    {
        public string po_number { get; set; }
        public Nullable<System.DateTime> receipt_date { get; set; }
    }
}
