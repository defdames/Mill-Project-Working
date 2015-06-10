using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_cyhist_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_cycnt_key { get; set; }
        public int in_cycnt_seqno { get; set; }
        public string in_cyccd_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_locn_key { get; set; }
        public double in_cycnt_qoh { get; set; }
        public System.DateTime in_cycnt_qohdt { get; set; }
        public double in_cycnt_cntqt { get; set; }
        public System.DateTime in_cycnt_cntdt { get; set; }
        public double in_cycnt_varqt { get; set; }
        public string in_cycnt_resn { get; set; }
        public string in_cycnt_remk { get; set; }
        public string in_cycnt_user { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime in_cyhist_chgdt { get; set; }
        public System.DateTime in_cyhist_crtdt { get; set; }
        public int in_cyhist_upcnt { get; set; }
        public double in_cycnt_vardol { get; set; }
        public int in_cycnt_error { get; set; }
        public Nullable<double> in_cycnt_aqoh { get; set; }
        public Nullable<double> in_cycnt_acntqt { get; set; }
        public Nullable<System.DateTime> in_cycnt_acntdt { get; set; }
        public Nullable<double> in_cycnt_avarqt { get; set; }
        public short in_cycnt_archivef { get; set; }
    }
}
