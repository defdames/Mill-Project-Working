using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class fc_fcst_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string fc_fcst_numbr { get; set; }
        public string fc_fcst_histn { get; set; }
        public string fc_fcst_qdflg { get; set; }
        public string ar_cust_key { get; set; }
        public string fc_fcst_expid { get; set; }
        public int fc_fcst_methd { get; set; }
        public System.DateTime fc_fcst_crtdt { get; set; }
        public int fc_fcst_buckt { get; set; }
        public System.DateTime fc_fcst_strdt { get; set; }
        public System.DateTime fc_fcst_enddt { get; set; }
        public double fc_fcst_perct { get; set; }
        public string fc_fcst_descr { get; set; }
        public System.DateTime fc_fcst_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int fc_fcst_upcnt { get; set; }
        public string fc_fcst_cstsh { get; set; }
    }
}
