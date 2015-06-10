using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class araging_oscar
    {
        public string BillTo { get; set; }
        public string CustPONo { get; set; }
        public string BillName { get; set; }
        public Nullable<System.DateTime> LstPayDate { get; set; }
        public string Terms { get; set; }
        public Nullable<double> CreditLimit { get; set; }
        public string HdrKey { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Type { get; set; }
        public string im_adres_tel { get; set; }
    }
}
