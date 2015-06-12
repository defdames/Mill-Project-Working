using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class active_formulas_using_costing
    {
        public string Plant { get; set; }
        public string Active_Formula { get; set; }
        public string Active_Rout_Key { get; set; }
        public short Active_Formula_V { get; set; }
        public System.DateTime sf_frmla_effdt { get; set; }
        public string sf_ingrd_key { get; set; }
        public Nullable<short> sf_ingrd_io { get; set; }
        public Nullable<double> sf_ingrd_qty { get; set; }
        public string sf_ingrd_uom { get; set; }
        public Nullable<double> ingredient_cost { get; set; }
        public string gl_cmp_key { get; set; }
        public string Unit_Cost_UOM { get; set; }
        public double sg { get; set; }
        public Nullable<double> totalcost { get; set; }
        public Nullable<double> actual_input_cost { get; set; }
        public string batch_uom { get; set; }
        public double in_item_spgvt { get; set; }
    }
}
