using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tbl_PDS_requests
    {
        public int reqno { get; set; }
        public string prodID { get; set; }
        public System.DateTime requestdate { get; set; }
        public System.DateTime requireddate { get; set; }
        public string requestedby { get; set; }
        public string itemcode { get; set; }
        public string market { get; set; }
        public Nullable<int> reason1 { get; set; }
        public Nullable<int> reason2 { get; set; }
        public Nullable<int> reason3 { get; set; }
        public string customer { get; set; }
        public Nullable<int> updatepds { get; set; }
        public string updateexp { get; set; }
        public Nullable<int> other { get; set; }
        public string otherexp { get; set; }
        public string notes { get; set; }
    }
}
