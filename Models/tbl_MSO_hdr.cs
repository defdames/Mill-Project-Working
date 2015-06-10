using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tbl_MSO_hdr
    {
        public int MSOno { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> ReqShipDate { get; set; }
        public string STname { get; set; }
        public string STaddy1 { get; set; }
        public string STaddy2 { get; set; }
        public string STaddy3 { get; set; }
        public string STphone { get; set; }
        public string SFname { get; set; }
        public string SFaddy1 { get; set; }
        public string SFaddy2 { get; set; }
        public string SFaddy3 { get; set; }
        public Nullable<int> HazYes { get; set; }
        public Nullable<int> HazNo { get; set; }
        public string Sender { get; set; }
        public Nullable<int> CC { get; set; }
        public string ShipVia { get; set; }
        public Nullable<int> UPS1 { get; set; }
        public Nullable<int> UPS2 { get; set; }
        public Nullable<int> UPS3 { get; set; }
        public Nullable<int> UPS4 { get; set; }
        public Nullable<int> UPS5 { get; set; }
        public Nullable<int> Prepaid { get; set; }
        public Nullable<int> Collect { get; set; }
        public Nullable<int> FDX1 { get; set; }
        public Nullable<int> FDX2 { get; set; }
        public Nullable<int> FDX3 { get; set; }
        public Nullable<int> FDX4 { get; set; }
        public Nullable<int> FDX5 { get; set; }
        public Nullable<int> USPS1 { get; set; }
        public Nullable<decimal> INSvalue { get; set; }
        public Nullable<decimal> Declaredvalue { get; set; }
        public string comments { get; set; }
    }
}
