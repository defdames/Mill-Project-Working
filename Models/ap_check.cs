using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check
    {
        public int CheckNo { get; set; }
        public string InvNo { get; set; }
        public System.DateTime InvDate { get; set; }
        public double Discount { get; set; }
        public string Reference { get; set; }
        public Nullable<double> NetAmt { get; set; }
        public Nullable<double> GrossAmt { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<double> CheckAmt { get; set; }
        public string VendorId { get; set; }
        public string RemitId { get; set; }
        public string RemitName { get; set; }
        public string RemitLine1 { get; set; }
        public string RemitLine2 { get; set; }
        public string RemitLine3 { get; set; }
        public string RemitCSZ { get; set; }
        public Nullable<double> sumnet { get; set; }
        public Nullable<double> sumdisc { get; set; }
        public Nullable<double> sumgross { get; set; }
        public string gl_cmp_key { get; set; }
        public string @void { get; set; }
    }
}
