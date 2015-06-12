using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_itqct_tbl
    {
        public string en_qcmst_key { get; set; }
        public System.DateTime en_itqct_effdt { get; set; }
        public string en_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string en_itqsp_key { get; set; }
        public System.DateTime en_itqsp_effdt { get; set; }
        public short en_itqct_type { get; set; }
        public string en_qcset_key { get; set; }
        public System.DateTime en_qcmst_effdt { get; set; }
        public System.DateTime en_itqct_inadt { get; set; }
        public double en_itqct_tfrq { get; set; }
        public int en_itqct_tfrt { get; set; }
        public double en_itqct_sfrq { get; set; }
        public double en_itqct_valu { get; set; }
        public double en_itqct_minv { get; set; }
        public double en_itqct_maxv { get; set; }
        public string en_itqct_txtv { get; set; }
        public string en_itqct_suom { get; set; }
        public string uom_key { get; set; }
        public int en_itqct_reqdf { get; set; }
        public int en_itqct_spcpf { get; set; }
        public int en_itqct_coapf { get; set; }
        public string en_itqct_testr { get; set; }
        public string en_itqct_cmnts { get; set; }
        public System.DateTime en_itqct_crtdt { get; set; }
        public System.DateTime en_itqct_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public int en_itqct_upcnt { get; set; }
        public int en_itqct_coavf { get; set; }
        public string en_itqct_desc { get; set; }
        public short en_itqct_eqmst { get; set; }
        public string qc_smpltyp_key { get; set; }
        public string en_uom_testfreq { get; set; }
        public string qc_lab_key { get; set; }
        public short en_itqct_mnmxop { get; set; }
        public double en_itqct_tmper { get; set; }
        public string qc_tstcode_key { get; set; }
        public int en_itqct_tsttype { get; set; }
    }
}
