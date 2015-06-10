using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_sales_journal_new
    {
        public string DocKey { get; set; }
        public Nullable<System.DateTime> TranDateKey { get; set; }
        public string DocType { get; set; }
        public string DocKeyType { get; set; }
        public string KeyLineType { get; set; }
        public string ar_bill_name { get; set; }
        public string in_prod_key { get; set; }
        public string ar_bill_key { get; set; }
        public string so_hdr_key { get; set; }
        public Nullable<double> LineAmt { get; set; }
        public Nullable<double> MiscAmt { get; set; }
        public Nullable<double> NetAmt { get; set; }
        public string gl_cmp_key { get; set; }
        public Nullable<double> ar_tax_amtc { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<double> freight { get; set; }
        public Nullable<double> HANDLING { get; set; }
        public Nullable<double> INSURANCE { get; set; }
        public string section { get; set; }
    }
}
