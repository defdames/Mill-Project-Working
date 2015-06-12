using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class im_cntct_tbl
    {
        public int im_cntct_key { get; set; }
        public string im_cntct_name { get; set; }
        public string im_cntct_title { get; set; }
        public string im_cntct_phone { get; set; }
        public string im_cntct_fax { get; set; }
        public string im_cntct_moble { get; set; }
        public string im_cntct_telex { get; set; }
        public string im_cntct_text { get; set; }
        public System.DateTime im_cntct_crtdt { get; set; }
        public System.DateTime im_cntct_chgdt { get; set; }
        public string en_stats_key { get; set; }
        public string sa_user_key { get; set; }
        public int im_cntct_upcnt { get; set; }
        public string im_cntct_itnet { get; set; }
    }
}
