using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ap_check_sap
    {
        public Nullable<int> CheckNo { get; set; }
        public string InvNo { get; set; }
        public System.DateTime InvDate { get; set; }
        public double Discount { get; set; }
        public string Reference { get; set; }
        public Nullable<double> NetAmt { get; set; }
        public double NetAmtSGD { get; set; }
        public double GrossAmt { get; set; }
        public double GrossAmtSGD { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<double> CheckAmt { get; set; }
        public Nullable<double> CheckAmtSGD { get; set; }
        public string VendorId { get; set; }
        public string RemitId { get; set; }
        public string RemitName { get; set; }
        public string RemitLine1 { get; set; }
        public string RemitLine2 { get; set; }
        public string RemitLine3 { get; set; }
        public string RemitCSZ { get; set; }
        public string sumnet { get; set; }
        public string sumnetsgd { get; set; }
        public string sumdisc { get; set; }
        public string sumgross { get; set; }
        public string sumgrosssgd { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_crncy_key { get; set; }
    }
}
