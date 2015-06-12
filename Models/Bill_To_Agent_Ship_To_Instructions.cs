using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Bill_To_Agent_Ship_To_Instructions
    {
        public string en_ship_key { get; set; }
        public string ar_ship_name { get; set; }
        public string shiptocity { get; set; }
        public string shiptostate { get; set; }
        public string ar_bill_key { get; set; }
        public string billname { get; set; }
        public string billtocity { get; set; }
        public string billtostate { get; set; }
        public string so_salsm_key { get; set; }
        public string im_incls_key { get; set; }
        public int im_insmst_key { get; set; }
        public string im_insmst_name { get; set; }
        public string text_value { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
