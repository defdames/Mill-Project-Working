using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_cntry_tbl
    {
        public string en_cntry_key { get; set; }
        public string en_cntry_desc { get; set; }
        public string en_cntry_iso2 { get; set; }
        public string en_cntry_iso3 { get; set; }
        public string en_cntry_isoa3 { get; set; }
        public string en_cntry_int2 { get; set; }
        public string en_cntry_int3 { get; set; }
        public short en_cntry_euf { get; set; }
        public string en_cntry_chkd { get; set; }
        public short en_cntry_tax { get; set; }
        public short en_cntry_vatc { get; set; }
        public System.DateTime en_cntry_crtdt { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime en_cntry_chgdt { get; set; }
        public int en_cntry_upcnt { get; set; }
        public string en_vatcd_key { get; set; }
        public Nullable<System.DateTime> en_cntry_eueffdt { get; set; }
        public short en_cntry_stateoptf { get; set; }
        public short en_cntry_postalcodeoptf { get; set; }
    }
}
