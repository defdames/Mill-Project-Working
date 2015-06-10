using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_igdout_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string sf_ingrd_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_locn_key { get; set; }
        public string sf_ingrd_iotp { get; set; }
        public double sf_ingrd_qty { get; set; }
        public double sf_ingrd_nomqty { get; set; }
        public double pm_igdout_qty { get; set; }
        public double pm_igdout_wipqt { get; set; }
        public string sf_ingrd_uom { get; set; }
        public string pm_igdout_tranuom { get; set; }
        public int fm_prtins_key { get; set; }
        public int fm_ingins_key { get; set; }
        public double pm_igdout_frzqty { get; set; }
        public string pm_igdout_frzuom { get; set; }
        public double pm_igdout_frzcst { get; set; }
        public double pm_igdout_stdqty { get; set; }
        public double pm_igdout_cstrat { get; set; }
        public double pm_igdout_exprat { get; set; }
        public int pm_igdout_upcnt { get; set; }
    }
}
