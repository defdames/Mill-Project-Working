using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_repack_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public short pm_repack_typ { get; set; }
        public string im_pack_key { get; set; }
        public string pm_tpack_key { get; set; }
        public double im_pack_qty { get; set; }
        public string im_pack_uom { get; set; }
        public double im_pack_yldfac { get; set; }
        public string pn_pack_fl { get; set; }
        public int pn_pack_seq { get; set; }
        public double pm_tpack_qty { get; set; }
        public string pm_tpack_uom { get; set; }
        public string pm_tpack_rout { get; set; }
        public Nullable<short> pm_repack_advschf { get; set; }
        public Nullable<int> pm_repack_pstpver { get; set; }
        public string pm_repack_astplid { get; set; }
        public int pm_repack_upcnt { get; set; }
    }
}
