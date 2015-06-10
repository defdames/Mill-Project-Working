using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_frmla_tbl
    {
        public string en_frmla_key { get; set; }
        public short en_frmla_ver { get; set; }
        public double en_frmla_bchsz { get; set; }
        public string en_frmla_buom { get; set; }
        public string en_frmla_desc { get; set; }
        public Nullable<System.DateTime> en_frmla_effdt { get; set; }
        public Nullable<System.DateTime> en_frmla_inadt { get; set; }
        public string en_frmla_stat { get; set; }
        public double en_frmla_yld { get; set; }
        public string en_frmla_chgdby { get; set; }
        public Nullable<System.DateTime> en_frmla_chgddt { get; set; }
        public string en_frmla_chgrsn { get; set; }
        public int en_frmla_upcnt { get; set; }
        public string en_frmla_cust { get; set; }
        public string en_frmlatype_key { get; set; }
        public short en_frmla_plmf { get; set; }
        public short en_frmla_mfgtyp { get; set; }
        public short en_frmla_allowsubf { get; set; }
    }
}
