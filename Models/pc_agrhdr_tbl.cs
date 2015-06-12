using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pc_agrhdr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pc_agrmt_key { get; set; }
        public short pc_agrhdr_ppcind { get; set; }
        public string pc_agrhdr_prod { get; set; }
        public short pc_agrhdr_key { get; set; }
        public string pc_agrhdr_desc { get; set; }
        public string pc_agrhdr_cmnts { get; set; }
        public short pc_agrhdr_inact { get; set; }
        public short pc_agrhdr_ordefff { get; set; }
        public Nullable<System.DateTime> pc_agrhdr_ordefdt { get; set; }
        public Nullable<System.DateTime> pc_agrhdr_ordiadt { get; set; }
        public short pc_agrhdr_shpefff { get; set; }
        public Nullable<System.DateTime> pc_agrhdr_shpefdt { get; set; }
        public Nullable<System.DateTime> pc_agrhdr_shpiadt { get; set; }
        public short pc_agrhdr_brkbasis { get; set; }
        public short pc_agrhdr_brktyp { get; set; }
        public string en_uom_qtylim { get; set; }
        public Nullable<double> pc_agrhdr_qty { get; set; }
        public short pc_agrhdr_tolbasis { get; set; }
        public Nullable<double> pc_agrhdr_undtol { get; set; }
        public Nullable<double> pc_agrhdr_ovrtol { get; set; }
        public string pc_agrhdr_brkuom { get; set; }
        public double pc_agrhdr_min { get; set; }
        public double pc_agrhdr_max { get; set; }
        public short pc_agrhdr_bprind { get; set; }
        public string pc_agrhdr_bpruom { get; set; }
        public double pc_agrhdr_basepr { get; set; }
        public string en_uom_analuom { get; set; }
        public Nullable<double> pc_agrhdr_analqty { get; set; }
        public Nullable<double> pc_agrhdr_aoneqty { get; set; }
        public short pc_agrhdr_allowpr { get; set; }
        public short pc_agrhdr_allwdpaf { get; set; }
        public short pc_agrhdr_prcactf { get; set; }
        public short pc_agrhdr_frgactf { get; set; }
        public short pc_agrhdr_splitf { get; set; }
        public short pc_agrhdr_cfprcf { get; set; }
        public string pc_bsprhd_key { get; set; }
        public string en_frtclass_key { get; set; }
        public string pc_agrhdr_inzone { get; set; }
        public string pc_agrhdr_sfzone { get; set; }
        public string pc_agrhdr_stzone { get; set; }
        public string in_whs_key { get; set; }
        public string sf_plant_key { get; set; }
        public string in_item_key { get; set; }
        public string pc_agrhdr_cmptftrm { get; set; }
        public string pc_agrhdr_cmptuom { get; set; }
        public Nullable<double> pc_agrhdr_cmptprc { get; set; }
        public string gl_cmp_ship { get; set; }
        public System.DateTime pc_agrhdr_crtdt { get; set; }
        public System.DateTime pc_agrhdr_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int pc_agrhdr_upcnt { get; set; }
        public short pc_agrhdr_reprchgf { get; set; }
    }
}
