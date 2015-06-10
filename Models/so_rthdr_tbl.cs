using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_rthdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_rthdr_key { get; set; }
        public string so_rthdr_refid { get; set; }
        public System.DateTime so_rthdr_rtdt { get; set; }
        public string en_cust_key { get; set; }
        public string ar_bill_key { get; set; }
        public string so_rthdr_connam { get; set; }
        public string so_rthdr_contel { get; set; }
        public string so_resn_code { get; set; }
        public short so_rthdr_stat { get; set; }
        public Nullable<System.DateTime> so_rtath_date { get; set; }
        public string so_hdr_key { get; set; }
        public string sa_user_id { get; set; }
        public short so_rthdr_insflag { get; set; }
        public string so_rthdr_authoriid { get; set; }
        public double so_rthdr_amnttotal { get; set; }
        public string ar_ship_key { get; set; }
        public Nullable<System.DateTime> so_rthdr_reqdt { get; set; }
        public Nullable<System.DateTime> so_rthdr_scheduldt { get; set; }
        public string sa_modified_by { get; set; }
        public System.DateTime so_rthdr_chgdt { get; set; }
        public string gl_crncy_key { get; set; }
        public int so_rthdr_upcnt { get; set; }
        public short so_rthdr_eustat { get; set; }
        public Nullable<System.DateTime> so_rthdr_eustatdt { get; set; }
        public string en_mode_key { get; set; }
        public string en_frgt_key { get; set; }
        public short so_rthdr_type { get; set; }
    }
}
