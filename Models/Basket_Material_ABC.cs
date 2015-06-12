using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Basket_Material_ABC
    {
        public string en_item_abcc { get; set; }
        public string in_item_key { get; set; }
        public string in_desc { get; set; }
        public Nullable<double> SumOfEndBal { get; set; }
        public Nullable<double> sumvalue { get; set; }
        public double en_item_sstk { get; set; }
        public string cmnts { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
        public string in_comcd_key { get; set; }
        public string en_class_key { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
