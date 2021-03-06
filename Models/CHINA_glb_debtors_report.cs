using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_glb_debtors_report
    {
        public string sequence_number { get; set; }
        public string BillTo { get; set; }
        public string CustPONo { get; set; }
        public string BillName { get; set; }
        public Nullable<System.DateTime> LstPayDate { get; set; }
        public string Terms { get; set; }
        public Nullable<double> CreditLimit { get; set; }
        public string HdrKey { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> Amountf { get; set; }
        public string Type { get; set; }
        public string im_adres_tel { get; set; }
        public string im_adres_itnet { get; set; }
        public string gl_cmp_key { get; set; }
        public string SalesOrder { get; set; }
        public string RedNumber { get; set; }
        public string GL_CRNCY_KEY { get; set; }
        public string EN_BILL_CRDTCRNCY { get; set; }
        public string country { get; set; }
    }
}
