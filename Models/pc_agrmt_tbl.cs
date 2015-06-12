using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pc_agrmt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pc_agrmt_key { get; set; }
        public string pc_agrmt_desc { get; set; }
        public string pc_agrmt_exdesc { get; set; }
        public string pc_type_key { get; set; }
        public short pc_agrmt_aprvf { get; set; }
        public string pc_agrmt_aprvby { get; set; }
        public short pc_agrmt_inact { get; set; }
        public Nullable<System.DateTime> pc_agrmt_ordefdt { get; set; }
        public Nullable<System.DateTime> pc_agrmt_ordiadt { get; set; }
        public Nullable<System.DateTime> pc_agrmt_shpefdt { get; set; }
        public Nullable<System.DateTime> pc_agrmt_shpiadt { get; set; }
        public short pc_type_limit { get; set; }
        public short pc_agrmt_limenfat { get; set; }
        public short pc_agrmt_limtrkat { get; set; }
        public short pc_agrmt_cuslmt { get; set; }
        public short pc_agrmt_billmt { get; set; }
        public short pc_agrmt_shplmt { get; set; }
        public string en_uom_qtylim { get; set; }
        public Nullable<double> pc_agrmt_qty { get; set; }
        public short pc_agrmt_tolbasis { get; set; }
        public Nullable<double> pc_agrmt_undtol { get; set; }
        public Nullable<double> pc_agrmt_ovrtol { get; set; }
        public string gl_crncy_key { get; set; }
        public double pc_agrmt_min { get; set; }
        public double pc_agrmt_max { get; set; }
        public short pc_agrmt_enhsetupf { get; set; }
        public short pc_agrmt_splitf { get; set; }
        public string pc_agrmt_slsmgr { get; set; }
        public string pc_agrmt_slsrep { get; set; }
        public string en_cust_key { get; set; }
        public string ar_ship_key { get; set; }
        public string pc_agrmt_cpono { get; set; }
        public string pc_agrmt_cmptnm { get; set; }
        public string pc_agrmt_cmptsrc { get; set; }
        public Nullable<System.DateTime> pc_agrmt_cmptdt { get; set; }
        public System.DateTime pc_agrmt_crtdt { get; set; }
        public System.DateTime pc_agrmt_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int pc_agrmt_upcnt { get; set; }
        public short pc_agrmt_reprchgf { get; set; }
        public string pc_agrmt_crtby { get; set; }
    }
}
