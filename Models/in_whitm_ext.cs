using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_whitm_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string gl_acct_key { get; set; }
        public string in_itgrp_key { get; set; }
        public Nullable<double> nonvolatile { get; set; }
        public Nullable<double> percent_metal { get; set; }
        public Nullable<System.DateTime> qcost_last_reviewed_date { get; set; }
        public string ruser_initials { get; set; }
        public Nullable<double> slifo_cost { get; set; }
        public string slifo_year { get; set; }
        public string remarks { get; set; }
        public int in_whitm_upcnt { get; set; }
    }
}
