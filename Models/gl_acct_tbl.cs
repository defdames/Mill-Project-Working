using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_acct_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_acct_key { get; set; }
        public string gl_acct_desc { get; set; }
        public string gl_class_key { get; set; }
        public string gl_class_key2 { get; set; }
        public string gl_class_key3 { get; set; }
        public string gl_class_key4 { get; set; }
        public string gl_class_key5 { get; set; }
        public string gl_type_key { get; set; }
        public string gl_acct_dbcrf { get; set; }
        public string gl_acct_cntra_acct { get; set; }
        public string gl_acct_cntrl_acct { get; set; }
        public string gl_bdgtwt_key { get; set; }
        public string gl_crncy_key { get; set; }
        public int gl_acct_upcnt { get; set; }
        public System.DateTime gl_acct_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_acct_crtdt { get; set; }
        public string gl_acct_glonly { get; set; }
        public Nullable<System.DateTime> gl_acct_inadt { get; set; }
        public short gl_acct_mcrncyf { get; set; }
        public short gl_acct_fctf { get; set; }
        public short gl_acct_3rdpartyf { get; set; }
        public short gl_acct_matchf { get; set; }
        public Nullable<int> gl_acct_easf { get; set; }
        public string gl_locacct_sgid { get; set; }
    }
}
