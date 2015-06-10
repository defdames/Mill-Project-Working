using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class otif_dashboard_detail_daily_picture
    {
        public string monthtime { get; set; }
        public string weektime { get; set; }
        public string otif { get; set; }
        public System.DateTime so_dtl_shsdt { get; set; }
        public System.DateTime so_dtl_reqdt { get; set; }
        public string OrderNo { get; set; }
        public Nullable<double> Dollars { get; set; }
        public Nullable<double> Pounds { get; set; }
        public string Type { get; set; }
        public string en_stats_key { get; set; }
        public Nullable<System.DateTime> so_dtl_shpdt { get; set; }
        public string in_prod_key { get; set; }
        public string ar_ship_key { get; set; }
        public string en_ship_name { get; set; }
        public System.DateTime so_dtl_entdt { get; set; }
        public System.DateTime so_dtl_prmdt { get; set; }
        public string so_dtl_stats { get; set; }
        public string en_item_key { get; set; }
        public string im_adres_city { get; set; }
        public string im_adres_state { get; set; }
        public string prod_status { get; set; }
        public string im_pack_key { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_crncy_key { get; set; }
        public short so_dtl_key { get; set; }
        public string top_customer_name { get; set; }
        public double so_dtl_ordqt { get; set; }
        public double so_dtl_shpqt { get; set; }
        public string so_hdr_cpono { get; set; }
        public string sa_created_by { get; set; }
        public string sa_modified_by { get; set; }
        public string salesmgr { get; set; }
        public string so_dtl_shpws { get; set; }
        public string en_cntry_key { get; set; }
        public Nullable<int> daysdiff { get; set; }
    }
}
