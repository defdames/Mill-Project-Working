using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dcmadj_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public short ar_dbcrdtl_key { get; set; }
        public string ar_dcmadj_key { get; set; }
        public short ar_dcmadj_keytyp { get; set; }
        public int ar_dcmadj_upcnt { get; set; }
        public System.DateTime ar_dcmadj_crtdt { get; set; }
        public System.DateTime ar_dcmadj_chgdt { get; set; }
        public int ar_dcmadj_seq { get; set; }
        public Nullable<System.DateTime> ar_dcmadj_ordefdt { get; set; }
        public Nullable<System.DateTime> ar_dcmadj_ordiadt { get; set; }
        public Nullable<System.DateTime> ar_dcmadj_shpefdt { get; set; }
        public Nullable<System.DateTime> ar_dcmadj_shpiadt { get; set; }
        public short ar_dcmadj_ctuff { get; set; }
        public string ar_dcmadj_uom { get; set; }
        public short ar_dcmadj_entcompf { get; set; }
        public string ar_dcmadj_proc { get; set; }
        public string pc_tmplt_key { get; set; }
        public short ar_dcmadj_cttyp { get; set; }
        public Nullable<double> ar_dcmadj_ctval { get; set; }
        public short ar_dcmadj_cashdisf { get; set; }
        public short ar_dcmadj_itemizef { get; set; }
        public short ar_dcmadj_ovrridef { get; set; }
        public short ar_dcmadj_taxf { get; set; }
        public short ar_dcmadj_basisf { get; set; }
        public short ar_dcmadj_addchnf { get; set; }
        public short ar_dcmadj_credchgf { get; set; }
        public short ar_dcmadj_manualf { get; set; }
        public short ar_dcmadj_commf { get; set; }
        public Nullable<double> ar_dcmadj_examtcf { get; set; }
        public Nullable<double> ar_dcmadj_examtc { get; set; }
        public Nullable<double> ar_dcmadj_examtncp { get; set; }
        public Nullable<double> ar_dcmadj_exaccrcf { get; set; }
        public Nullable<double> ar_dcmadj_exaccrc { get; set; }
        public Nullable<double> ar_dcmadj_exaccrcp { get; set; }
        public Nullable<double> ar_dcmadj_valaccr { get; set; }
        public short ar_dcmadj_grossf { get; set; }
        public short ar_dcmadj_appseq { get; set; }
        public short ar_dcmadj_extactf { get; set; }
        public string pc_pcomp_key { get; set; }
        public double ar_dcmadj_vatc { get; set; }
        public double ar_dcmadj_vatcf { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public short ar_dcmadj_incicprcf { get; set; }
        public string en_vend_key { get; set; }
        public short ar_dcmadj_compforf { get; set; }
    }
}
