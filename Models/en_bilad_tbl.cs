using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_bilad_tbl
    {
        public string en_bill_key { get; set; }
        public short im_adrtp_key { get; set; }
        public int im_adres_key { get; set; }
        public System.DateTime en_bilad_crtdt { get; set; }
        public System.DateTime en_bilad_chgdt { get; set; }
        public string en_stats_key { get; set; }
        public string sa_user_key { get; set; }
        public string en_bilad_cmnts { get; set; }
        public int im_adrtp_upcnt { get; set; }
    }
}
