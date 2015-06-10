using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_qcmst_tbl
    {
        public string en_qcmst_key { get; set; }
        public System.DateTime en_qcmst_effdt { get; set; }
        public short en_qcmst_type { get; set; }
        public System.DateTime en_qcmst_inadt { get; set; }
        public string en_qcmst_desc { get; set; }
        public double en_qcmst_tfrq { get; set; }
        public int en_qcmst_tfrt { get; set; }
        public double en_qcmst_sfrq { get; set; }
        public double en_qcmst_valu { get; set; }
        public double en_qcmst_minv { get; set; }
        public double en_qcmst_maxv { get; set; }
        public string en_qcmst_txtv { get; set; }
        public string en_qcmst_suom { get; set; }
        public string uom_key { get; set; }
        public string en_qcmst_cmnts { get; set; }
        public System.DateTime en_qcmst_crtdt { get; set; }
        public System.DateTime en_qcmst_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_qcmst_upcnt { get; set; }
        public string qc_smpltyp_key { get; set; }
        public string qc_lab_key { get; set; }
        public string en_uom_testfreq { get; set; }
        public short en_qcmst_mnmxop { get; set; }
        public double en_qcmst_tmper { get; set; }
        public string qc_tstcode_key { get; set; }
        public int en_qcmst_tsttype { get; set; }
    }
}
