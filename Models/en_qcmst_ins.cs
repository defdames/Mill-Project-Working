using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_qcmst_ins
    {
        public string en_qcmst_key { get; set; }
        public System.DateTime en_qcmst_effdt { get; set; }
        public int im_insmst_key { get; set; }
        public System.DateTime im_insmst_joindt { get; set; }
        public string sa_user_key { get; set; }
    }
}
