using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Basket_Material_ABC_10
    {
        public string en_item_abcc { get; set; }
        public string in_item_key { get; set; }
        public string in_desc { get; set; }
        public Nullable<double> SumOfEndBal { get; set; }
        public double en_item_sstk { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
    }
}
