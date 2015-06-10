using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_ivadj_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string ar_ivhdr_key { get; set; }
        public int ar_ivdtl_key { get; set; }
        public string ar_ivadj_key { get; set; }
        public short ar_ivadj_keytyp { get; set; }
        public int ar_ivadj_upcnt { get; set; }
        public System.DateTime ar_ivadj_crtdt { get; set; }
        public System.DateTime ar_ivadj_chgdt { get; set; }
        public int ar_ivadj_seq { get; set; }
        public Nullable<System.DateTime> ar_ivadj_ordefdt { get; set; }
        public Nullable<System.DateTime> ar_ivadj_ordiadt { get; set; }
        public Nullable<System.DateTime> ar_ivadj_shpefdt { get; set; }
        public Nullable<System.DateTime> ar_ivadj_shpiadt { get; set; }
        public short ar_ivadj_ctuff { get; set; }
        public string ar_ivadj_uom { get; set; }
        public short ar_ivadj_entcompf { get; set; }
        public string ar_ivadj_proc { get; set; }
        public string pc_tmplt_key { get; set; }
        public short ar_ivadj_cttyp { get; set; }
        public Nullable<double> ar_ivadj_ctval { get; set; }
        public short ar_ivadj_cashdisf { get; set; }
        public short ar_ivadj_itemizef { get; set; }
        public short ar_ivadj_ovrridef { get; set; }
        public short ar_ivadj_taxf { get; set; }
        public short ar_ivadj_basisf { get; set; }
        public short ar_ivadj_addchnf { get; set; }
        public short ar_ivadj_credchgf { get; set; }
        public short ar_ivadj_manualf { get; set; }
        public short ar_ivadj_commf { get; set; }
        public Nullable<double> ar_ivadj_examtcf { get; set; }
        public Nullable<double> ar_ivadj_examtc { get; set; }
        public Nullable<double> ar_ivadj_examtncp { get; set; }
        public Nullable<double> ar_ivadj_exaccrcf { get; set; }
        public Nullable<double> ar_ivadj_exaccrc { get; set; }
        public Nullable<double> ar_ivadj_exaccrcp { get; set; }
        public Nullable<double> ar_ivadj_valaccr { get; set; }
        public short ar_ivadj_grossf { get; set; }
        public short ar_ivadj_appseq { get; set; }
        public short ar_ivadj_extactf { get; set; }
        public string pc_pcomp_key { get; set; }
        public double ar_ivadj_vatc { get; set; }
        public double ar_ivadj_vatcf { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public short ar_ivadj_incicprcf { get; set; }
        public string en_vend_key { get; set; }
        public short ar_ivadj_compforf { get; set; }
    }
}
