using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class currency_rate_table_cmp_commission_report_cp1
    {
        public int currencyPK { get; set; }
        public System.DateTime gl_crcnv_bdate { get; set; }
        public System.DateTime gl_crcnv_edate { get; set; }
        public double gl_crcnv_rate { get; set; }
        public string gl_cmp_key { get; set; }
        public string gl_CRNCY_FROM { get; set; }
        public string gl_CRNCY_TO { get; set; }
    }
}
