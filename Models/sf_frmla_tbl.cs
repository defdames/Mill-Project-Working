using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_frmla_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public double sf_frmla_bchsz { get; set; }
        public string sf_frmla_buom { get; set; }
        public string sf_frmla_desc { get; set; }
        public Nullable<System.DateTime> sf_frmla_effdt { get; set; }
        public Nullable<System.DateTime> sf_frmla_inadt { get; set; }
        public string sf_frmla_stat { get; set; }
        public double sf_frmla_yld { get; set; }
        public string sf_frmla_chgdby { get; set; }
        public Nullable<System.DateTime> sf_frmla_chgddt { get; set; }
        public string sf_frmla_chgrsn { get; set; }
        public int sf_frmla_upcnt { get; set; }
        public string sf_frmla_cust { get; set; }
        public string en_frmlatype_key { get; set; }
        public short en_frmla_mfgtyp { get; set; }
        public short sf_frmla_allowsubf { get; set; }
    }
}
