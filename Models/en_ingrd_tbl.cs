using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_ingrd_tbl
    {
        public string en_frmla_key { get; set; }
        public short en_frmla_ver { get; set; }
        public string en_ingrd_key { get; set; }
        public short en_ingrd_io { get; set; }
        public string en_ingrd_iotp { get; set; }
        public double en_ingrd_qty { get; set; }
        public string en_ingrd_uom { get; set; }
        public double en_ingrd_bspc { get; set; }
        public string im_pack_key { get; set; }
        public double en_ingrd_actqt { get; set; }
        public string en_ingrd_actuom { get; set; }
        public short en_ingrd_scltp { get; set; }
        public double en_ingrd_scmax { get; set; }
        public int en_ingrd_entsq { get; set; }
        public double en_ingrd_scmin { get; set; }
        public double en_ingrd_stpsz { get; set; }
        public double en_ingrd_yld { get; set; }
        public int fm_ingins_key { get; set; }
        public Nullable<double> en_ingrd_asinfctr { get; set; }
        public int en_ingrd_sbgrp { get; set; }
        public string en_ingrd_sbkey { get; set; }
        public int en_ingrd_upcnt { get; set; }
        public short en_ingrd_allowsubf { get; set; }
    }
}
