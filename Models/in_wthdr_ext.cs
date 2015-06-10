using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_wthdr_ext
    {
        public string gl_cmp_key { get; set; }
        public string in_wthdr_towhs { get; set; }
        public string in_wthdr_key { get; set; }
        public string ex_ship_mark1 { get; set; }
        public string ex_ship_mark2 { get; set; }
        public string ex_ship_mark3 { get; set; }
        public string ex_ship_mark4 { get; set; }
        public string ex_ship_mark5 { get; set; }
        public string ex_ship_mark6 { get; set; }
        public string port_discharge { get; set; }
        public string booknum { get; set; }
        public string xvessel_name { get; set; }
        public string xwport_of_loading { get; set; }
        public string container_size { get; set; }
        public string in_wthdr_instrux { get; set; }
        public Nullable<System.DateTime> deliver_date { get; set; }
        public string po_number { get; set; }
        public string en_mode_key { get; set; }
        public int in_wthdr_upcnt { get; set; }
    }
}
