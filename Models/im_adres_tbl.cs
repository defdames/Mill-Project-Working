using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class im_adres_tbl
    {
        public int im_adres_key { get; set; }
        public string im_adres_name { get; set; }
        public string im_adres_line1 { get; set; }
        public string im_adres_line2 { get; set; }
        public string im_adres_line3 { get; set; }
        public string im_adres_city { get; set; }
        public string im_adres_state { get; set; }
        public string im_adres_cntry { get; set; }
        public string im_adres_pczip { get; set; }
        public string im_adres_tel { get; set; }
        public string im_adres_fax { get; set; }
        public string im_adres_telex { get; set; }
        public string im_adres_modem { get; set; }
        public System.DateTime im_adres_crtdt { get; set; }
        public System.DateTime im_adres_chgdt { get; set; }
        public string en_stats_key { get; set; }
        public string sa_user_key { get; set; }
        public string im_adres_cmnts { get; set; }
        public string im_adres_itnet { get; set; }
        public string en_frtzone_key { get; set; }
        public string en_geocode_key { get; set; }
        public int im_adres_upcnt { get; set; }
        public string en_cntry_key { get; set; }
    }
}
