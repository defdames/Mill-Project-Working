using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_lot_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string sf_ingrd_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string in_lot_key { get; set; }
        public short pm_lot_pflg { get; set; }
        public double pm_lot_spgvt { get; set; }
        public short pm_lot_holdf { get; set; }
        public short pm_lot_grde { get; set; }
        public double pm_lot_qty { get; set; }
        public string pm_lot_uom { get; set; }
        public double pm_lot_actqt { get; set; }
        public string pm_lot_actuom { get; set; }
        public int pm_lot_upcnt { get; set; }
        public double pm_lot_wipqt { get; set; }
        public double pm_lot_qcqty { get; set; }
    }
}
