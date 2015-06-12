using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class im_insmst_tbl
    {
        public int im_insmst_key { get; set; }
        public string im_incls_key { get; set; }
        public short im_insmst_txtflg { get; set; }
        public string im_insmst_name { get; set; }
        public string im_insmst_inttxt { get; set; }
        public string im_insmst_extfile { get; set; }
        public int im_insmst_upcnt { get; set; }
        public System.DateTime im_insmst_effdt { get; set; }
        public Nullable<System.DateTime> im_insmst_inadt { get; set; }
        public int im_cppmst_key { get; set; }
        public int im_prpmst_key { get; set; }
    }
}
