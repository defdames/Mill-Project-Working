using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_resn_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_resn_key { get; set; }
        public string in_resn_desc { get; set; }
        public string gl_acct_key { get; set; }
        public System.DateTime in_resn_crtdt { get; set; }
        public System.DateTime in_resn_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int in_resn_upcnt { get; set; }
        public short in_resn_updinvf { get; set; }
        public short in_resn_Stduse { get; set; }
        public short in_resn_Recnuse { get; set; }
        public short in_resn_financeUse { get; set; }
        public Nullable<short> in_resn_updwhsf { get; set; }
    }
}
