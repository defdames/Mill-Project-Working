using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class blend_on_hand
    {
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public short gl_perod_year { get; set; }
        public short gl_perod_id { get; set; }
        public double in_stkmv_boh { get; set; }
        public double in_stkmv_eoh { get; set; }
        public double in_stkmv_rcpt { get; set; }
        public double in_stkmv_iss { get; set; }
        public double in_stkmv_adj { get; set; }
        public double in_stkmv_ordtpib { get; set; }
        public double in_stkmv_ordtpii { get; set; }
        public double in_stkmv_ordtpri { get; set; }
        public double in_stkmv_ordtprb { get; set; }
        public double boh { get; set; }
        public double in_stkmv_ordtprx { get; set; }
        public double in_stkmv_ordtpix { get; set; }
        public double in_stkmv_ordtprc { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
