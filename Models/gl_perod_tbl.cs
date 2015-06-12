using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_perod_tbl
    {
        public string gl_cmp_key { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
        public Nullable<System.DateTime> gl_perod_stdt { get; set; }
        public Nullable<System.DateTime> gl_perod_enddt { get; set; }
        public string gl_perod_currp { get; set; }
        public string gl_perod_openp { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_perod_chgdt { get; set; }
        public System.DateTime gl_perod_crtdt { get; set; }
        public short gl_perod_type { get; set; }
        public int gl_perod_seqno { get; set; }
        public string gl_perod_adjid { get; set; }
        public string gl_perod_aropenp { get; set; }
        public string gl_perod_apopenp { get; set; }
        public string gl_perod_poopenp { get; set; }
        public string gl_perod_soopenp { get; set; }
        public string gl_perod_inopenp { get; set; }
        public string gl_perod_pmopenp { get; set; }
        public int gl_perod_upcnt { get; set; }
    }
}
