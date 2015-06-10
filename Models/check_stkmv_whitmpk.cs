using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class check_stkmv_whitmpk
    {
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<double> in_stkmv_eoh { get; set; }
        public Nullable<double> in_whitmpk_qoh { get; set; }
    }
}
