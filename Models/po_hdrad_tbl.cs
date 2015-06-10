using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_hdrad_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public string po_hdrad_key { get; set; }
        public string po_hdrad_name { get; set; }
        public string po_hdrad_adr1 { get; set; }
        public string po_hdrad_adr2 { get; set; }
        public string po_hdrad_adr3 { get; set; }
        public string po_hdrad_cty { get; set; }
        public string po_hdrad_state { get; set; }
        public string po_hdrad_pczip { get; set; }
        public string po_hdrad_tel { get; set; }
        public string po_hdrad_telex { get; set; }
        public string po_hdrad_fax { get; set; }
        public string en_cntry_key { get; set; }
        public System.DateTime po_hdrad_crtdt { get; set; }
        public System.DateTime po_hdrad_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public string po_hdrad_cmnts { get; set; }
        public int po_hdrad_upcnt { get; set; }
    }
}
