using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sa_user_tbl
    {
        public sa_user_tbl()
        {
            this.po_hdr_tbl = new List<po_hdr_tbl>();
        }

        public string sa_user_key { get; set; }
        public string sa_user_paswd { get; set; }
        public string sa_user_name { get; set; }
        public string sa_user_adr1 { get; set; }
        public string sa_user_adr2 { get; set; }
        public string sa_user_city { get; set; }
        public string sa_user_state { get; set; }
        public string sa_user_postc { get; set; }
        public string sa_user_tel { get; set; }
        public string sa_user_fax { get; set; }
        public string gl_cmp_key { get; set; }
        public string sa_user_defbr { get; set; }
        public string sa_user_defpt { get; set; }
        public string sa_user_defwh { get; set; }
        public Nullable<System.DateTime> sa_user_lastlogin { get; set; }
        public string sa_user_deffr { get; set; }
        public System.DateTime sa_user_strdt { get; set; }
        public System.DateTime sa_user_enddt { get; set; }
        public short sa_user_loginframe { get; set; }
        public string sa_osuser_key { get; set; }
        public short sa_user_webf { get; set; }
        public short sa_user_desktopf { get; set; }
        public string sa_user_email { get; set; }
        public string sa_user_ceuser { get; set; }
        public string sa_user_cepaswd { get; set; }
        public string sa_user_colorset { get; set; }
        public short sa_user_enticnf { get; set; }
        public int sa_user_upcnt { get; set; }
        public string sa_user_loginname { get; set; }
        public string sa_user_sgid { get; set; }
        public string en_role_key { get; set; }
        public int sa_user_options { get; set; }
        public short sa_user_locked { get; set; }
        public Nullable<System.DateTime> sa_user_apprinadt { get; set; }
        public short sa_user_skipapprf { get; set; }
        public string sa_user_manager { get; set; }
        public string sa_user_newappr { get; set; }
        public Nullable<short> sa_user_chngpwd { get; set; }
        public virtual ICollection<po_hdr_tbl> po_hdr_tbl { get; set; }
    }
}
