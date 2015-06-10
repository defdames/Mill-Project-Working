using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_on_time_in_force
    {
        public string so_hdr_key { get; set; }
        public System.DateTime so_hdr_crtdt { get; set; }
        public string ar_ship_key { get; set; }
        public string gl_cmp_key { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
        public Nullable<System.DateTime> so_dtl_shpdt { get; set; }
        public string in_prod_key { get; set; }
        public string in_prod_desc { get; set; }
        public System.DateTime so_dtl_entdt { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public double so_dtl_ordqt { get; set; }
        public double so_dtl_shpqt { get; set; }
        public double so_dtl_aordq { get; set; }
        public string so_dtl_cpono { get; set; }
        public Nullable<double> im_pack_qty { get; set; }
        public string en_stats_key { get; set; }
        public string en_ship_name { get; set; }
        public string im_adres_city { get; set; }
        public string im_adres_cntry { get; set; }
        public string ar_ivhdr_key { get; set; }
        public Nullable<System.DateTime> ar_ivhdr_crtdt { get; set; }
        public string so_ship_key { get; set; }
        public Nullable<double> so_shpqt_qty { get; set; }
    }
}
