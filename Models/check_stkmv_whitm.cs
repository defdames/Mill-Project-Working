using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class check_stkmv_whitm
    {
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public Nullable<double> in_stkmv_eoh { get; set; }
        public Nullable<double> in_whitm_qoh { get; set; }
    }
}
