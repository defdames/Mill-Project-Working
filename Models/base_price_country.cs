using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class base_price_country
    {
        public string gl_cmp_key { get; set; }
        public string pc_bsprhd_key { get; set; }
        public short pc_bsprdt_ppcind { get; set; }
        public string pc_bsprdt_prod { get; set; }
        public string im_pack_key { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_ordefdt { get; set; }
        public Nullable<System.DateTime> pc_bsprdt_ordiadt { get; set; }
        public double pc_bsprdt_price { get; set; }
        public string pc_bsprdt_uom { get; set; }
        public string en_prod_key { get; set; }
        public string en_prod_desc { get; set; }
        public string name { get; set; }
        public string im_adres_cntry { get; set; }
    }
}
