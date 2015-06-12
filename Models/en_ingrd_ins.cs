using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_ingrd_ins
    {
        public string en_frmla_key { get; set; }
        public short en_frmla_ver { get; set; }
        public string en_ingrd_key { get; set; }
        public short en_ingrd_io { get; set; }
        public int im_insmst_key { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime im_insmst_joindt { get; set; }
    }
}
