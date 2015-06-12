using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ACC_INVCOMM_REPORT
    {
        public Nullable<System.DateTime> tran_date_key { get; set; }
        public string mktseg { get; set; }
        public string agent { get; set; }
        public string product { get; set; }
        public string en_prod_desc { get; set; }
        public string itmclass { get; set; }
        public string en_item_key { get; set; }
        public string en_catlg_key { get; set; }
        public string im_pack_key { get; set; }
        public string shipkey { get; set; }
        public string en_ship_name { get; set; }
        public string hdrkey { get; set; }
        public int dtlkey { get; set; }
        public string salestype { get; set; }
        public string soldto { get; set; }
        public Nullable<double> dollars { get; set; }
        public Nullable<decimal> pounds { get; set; }
        public string gl_cmp_key { get; set; }
        public string ar_bill_key { get; set; }
        public string ar_bill_name { get; set; }
        public Nullable<double> cost_value { get; set; }
        public Nullable<decimal> kgs { get; set; }
        public string CD { get; set; }
        public string Country { get; set; }
        public string whseacct { get; set; }
        public string Invoice_Num { get; set; }
        public string SO_Num { get; set; }
        public string Ship_Whse { get; set; }
        public string Sales_Type { get; set; }
        public string TYPE { get; set; }
        public string ar_DCMADJ_key { get; set; }
        public Nullable<double> AR_DCMADJ_EXAMTCF { get; set; }
    }
}
