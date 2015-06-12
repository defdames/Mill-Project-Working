using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class tmp_List_of_Powders_AR_tbl
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string frmkey { get; set; }
        public string Ing { get; set; }
        public Nullable<double> Qty { get; set; }
        public string UOM { get; set; }
        public string Manufacture { get; set; }
        public Nullable<int> L { get; set; }
        public string Status { get; set; }
    }
}
