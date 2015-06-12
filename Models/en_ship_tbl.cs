using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_ship_tbl
    {
        public en_ship_tbl()
        {
            this.Sample_Recertifications = new List<Sample_Recertifications>();
        }

        public string en_ship_key { get; set; }
        public string en_cust_key { get; set; }
        public string en_ship_name { get; set; }
        public short en_ship_pri { get; set; }
        public string en_ship_ctgy { get; set; }
        public string en_ship_taxf { get; set; }
        public string en_tax_key { get; set; }
        public string en_ship_rslen { get; set; }
        public string en_ship_via { get; set; }
        public string en_comp_key { get; set; }
        public string en_stats_key { get; set; }
        public System.DateTime en_ship_crtdt { get; set; }
        public System.DateTime en_ship_chgdt { get; set; }
        public string en_ship_cmnts { get; set; }
        public string sa_user_key { get; set; }
        public int en_ship_dyely { get; set; }
        public short en_ship_intf { get; set; }
        public short en_ship_snglwhs { get; set; }
        public string en_frgt_key { get; set; }
        public string en_sltyp_key { get; set; }
        public string en_shipprgrp_key1 { get; set; }
        public string en_shipprgrp_key2 { get; set; }
        public string en_shipprgrp_key3 { get; set; }
        public string en_shipprgrp_key4 { get; set; }
        public string en_shipprgrp_key5 { get; set; }
        public string en_shipprgrp_key6 { get; set; }
        public string en_mode_key { get; set; }
        public string en_service_key { get; set; }
        public short en_ship_shpkreqf { get; set; }
        public string en_ship_shpkminlbl { get; set; }
        public string en_ship_shpkmaxlbl { get; set; }
        public string en_ship_shpknxtlbl { get; set; }
        public string en_ship_shpkinfmt { get; set; }
        public string en_ship_shpkoutfmt { get; set; }
        public short en_ship_bcconfigf { get; set; }
        public short en_ship_ovrridsof { get; set; }
        public short en_ship_multipof { get; set; }
        public Nullable<int> en_ship_noprntlbs { get; set; }
        public Nullable<int> en_ship_nochldlbs { get; set; }
        public short en_ship_sndcasef { get; set; }
        public short en_ship_sndpltf { get; set; }
        public short en_ship_sndshpcntf { get; set; }
        public string en_ship_plabelfmt { get; set; }
        public string en_ship_chlabelfmt { get; set; }
        public string en_ship_storeid { get; set; }
        public short en_ship_storef { get; set; }
        public short en_ship_ucceanf { get; set; }
        public int en_ship_upcnt { get; set; }
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string en_enduse_key { get; set; }
        public virtual ICollection<Sample_Recertifications> Sample_Recertifications { get; set; }
    }
}
