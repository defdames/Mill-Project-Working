using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class araging_zone
    {
        public string BillTo { get; set; }
        public string CustPONo { get; set; }
        public string BillName { get; set; }
        public Nullable<System.DateTime> LstPayDate { get; set; }
        public string Terms { get; set; }
        public Nullable<double> CreditLimit { get; set; }
        public string HdrKey { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> ivDate { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Type { get; set; }
        public string im_adres_tel { get; set; }
        public string zone { get; set; }
        public string region { get; set; }
        public string ttype { get; set; }
        public string seq { get; set; }
        public string Company { get; set; }
    }
}
