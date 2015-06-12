using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_tran_tbl
    {
        public string gl_cmp_key { get; set; }
        public int gl_tran_key { get; set; }
        public string gl_acct_key { get; set; }
        public System.DateTime gl_tran_date { get; set; }
        public double gl_tran_qty { get; set; }
        public string gl_tran_ref1 { get; set; }
        public string gl_tran_ref2 { get; set; }
        public string gl_tran_desc { get; set; }
        public string gl_tran_applc { get; set; }
        public string sa_user_key { get; set; }
        public int sa_frame_id { get; set; }
        public short sa_term_id { get; set; }
        public Nullable<System.DateTime> gl_tran_crtdt { get; set; }
        public Nullable<System.DateTime> gl_tran_chgdt { get; set; }
        public int gl_tran_upcnt { get; set; }
        public int gl_perod_seqno { get; set; }
        public System.DateTime gl_tran_subcrtdt { get; set; }
        public double gl_tran_dbamtc { get; set; }
        public double gl_tran_cramtc { get; set; }
        public string gl_bkcd_key { get; set; }
        public int gl_bkcd_jnum { get; set; }
        public decimal gl_tran_pk { get; set; }
    }
}
