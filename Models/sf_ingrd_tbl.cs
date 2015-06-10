using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_ingrd_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string sf_ingrd_key { get; set; }
        public short sf_ingrd_io { get; set; }
        public string sf_ingrd_iotp { get; set; }
        public double sf_ingrd_qty { get; set; }
        public string sf_ingrd_uom { get; set; }
        public double sf_ingrd_bspc { get; set; }
        public string im_pack_key { get; set; }
        public double sf_ingrd_actqt { get; set; }
        public string sf_ingrd_actuom { get; set; }
        public short sf_ingrd_scltp { get; set; }
        public double sf_ingrd_scmax { get; set; }
        public double sf_ingrd_scmin { get; set; }
        public double sf_ingrd_stpsz { get; set; }
        public int sf_ingrd_entsq { get; set; }
        public double sf_ingrd_yld { get; set; }
        public Nullable<double> sf_ingrd_asinfctr { get; set; }
        public string pc_pcomp_key { get; set; }
        public int pc_favchdr_key { get; set; }
        public int fm_ingins_key { get; set; }
        public int sf_ingrd_sbgrp { get; set; }
        public string sf_ingrd_sbkey { get; set; }
        public int sf_ingrd_upcnt { get; set; }
        public double sf_ingrd_opyld { get; set; }
        public short sf_ingrd_allowsubf { get; set; }
    }
}
