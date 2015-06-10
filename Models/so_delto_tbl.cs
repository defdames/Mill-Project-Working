using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_delto_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public short im_adrtp_key { get; set; }
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
        public string im_adres_itnet { get; set; }
        public string im_adres_cmnts { get; set; }
        public string sa_modified_by { get; set; }
        public string sa_created_by { get; set; }
        public System.DateTime sa_change_date { get; set; }
        public System.DateTime sa_create_date { get; set; }
        public string en_geocode_key { get; set; }
        public string en_frtzone_key { get; set; }
        public int so_delto_upcnt { get; set; }
        public string en_cntry_key { get; set; }
    }
}
