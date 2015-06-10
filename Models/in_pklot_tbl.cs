using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_pklot_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public int in_pick_key { get; set; }
        public int in_pkpeg_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_locn_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public double in_pklot_pikqt { get; set; }
        public double in_pklot_pikpk { get; set; }
        public double in_pklot_shpqt { get; set; }
        public double in_pklot_shppk { get; set; }
        public double in_pklot_reqqt { get; set; }
        public double in_pklot_reqpk { get; set; }
        public double in_pklot_loadqt { get; set; }
        public double in_pklot_loadpk { get; set; }
        public string in_pklot_typ { get; set; }
        public string in_pklot_entty { get; set; }
        public string in_pklot_doc { get; set; }
        public int in_pklot_line { get; set; }
        public string gl_cmp_demand { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime in_pklot_chgdt { get; set; }
        public System.DateTime in_pklot_crtdt { get; set; }
        public short in_pklot_strmlnpc { get; set; }
        public int in_pklot_upcnt { get; set; }
    }
}
