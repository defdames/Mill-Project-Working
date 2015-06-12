using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_smcom_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_salsm_key { get; set; }
        public string ar_cust_key { get; set; }
        public string ar_ship_key { get; set; }
        public string so_pgc_key { get; set; }
        public string so_prod_key { get; set; }
        public double so_smcom_cmval { get; set; }
        public System.DateTime so_smcom_effdt { get; set; }
        public System.DateTime so_smcom_inadt { get; set; }
        public int so_smcom_upcnt { get; set; }
        public short so_smcom_cmtypf { get; set; }
        public string so_smcom_cmuom { get; set; }
    }
}
