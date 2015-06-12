using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class lang_im_adres_tbl
    {
        public int im_adres_key { get; set; }
        public string language { get; set; }
        public string im_adres_name { get; set; }
        public string im_adres_line1 { get; set; }
        public string im_adres_line2 { get; set; }
        public string im_adres_line3 { get; set; }
        public string im_adres_city { get; set; }
        public string im_adres_state { get; set; }
        public string im_adres_cntry { get; set; }
        public string im_adres_pczip { get; set; }
    }
}
