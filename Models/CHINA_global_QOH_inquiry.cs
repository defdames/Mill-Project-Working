using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_global_QOH_inquiry
    {
        public string item { get; set; }
        public string ware { get; set; }
        public string Packloc { get; set; }
        public string Packlot { get; set; }
        public string Packkey { get; set; }
        public Nullable<double> Packqty { get; set; }
        public string Company { get; set; }
        public Nullable<double> in_lot_qoh { get; set; }
        public Nullable<System.DateTime> upload_date { get; set; }
        public Nullable<double> packcost { get; set; }
    }
}
