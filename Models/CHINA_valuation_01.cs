using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_valuation_01
    {
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public short gl_perod_id { get; set; }
        public short gl_perod_year { get; set; }
        public string pack_key { get; set; }
        public Nullable<double> qoh { get; set; }
        public string in_desc { get; set; }
        public string UomKey { get; set; }
        public Nullable<double> NoPkg { get; set; }
        public Nullable<double> UnitCost { get; set; }
        public Nullable<double> OrigCost { get; set; }
        public string GL_ACCT_DESC { get; set; }
        public Nullable<double> ExtCost { get; set; }
        public Nullable<double> OrigExtCost { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
