using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_dtladj_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string so_hdr_key { get; set; }
        public short so_dtl_key { get; set; }
        public string so_dtladj_key { get; set; }
        public short so_dtladj_keytyp { get; set; }
        public int so_dtladj_upcnt { get; set; }
        public System.DateTime so_dtladj_crtdt { get; set; }
        public System.DateTime so_dtladj_chgdt { get; set; }
        public int so_dtladj_seq { get; set; }
        public Nullable<System.DateTime> so_dtladj_ordefdt { get; set; }
        public Nullable<System.DateTime> so_dtladj_ordiadt { get; set; }
        public Nullable<System.DateTime> so_dtladj_shpefdt { get; set; }
        public Nullable<System.DateTime> so_dtladj_shpiadt { get; set; }
        public short so_dtladj_ctuff { get; set; }
        public string so_dtladj_uom { get; set; }
        public short so_dtladj_entcompf { get; set; }
        public string so_dtladj_proc { get; set; }
        public string pc_tmplt_key { get; set; }
        public short so_dtladj_cttyp { get; set; }
        public Nullable<double> so_dtladj_ctval { get; set; }
        public short so_dtladj_cashdisf { get; set; }
        public short so_dtladj_itemizef { get; set; }
        public short so_dtladj_ovrridef { get; set; }
        public short so_dtladj_taxf { get; set; }
        public short so_dtladj_basisf { get; set; }
        public short so_dtladj_addchnf { get; set; }
        public short so_dtladj_credchgf { get; set; }
        public short so_dtladj_manualf { get; set; }
        public short so_dtladj_commf { get; set; }
        public Nullable<double> so_dtladj_examtcf { get; set; }
        public Nullable<double> so_dtladj_examtc { get; set; }
        public Nullable<double> so_dtladj_examtncp { get; set; }
        public Nullable<double> so_dtladj_exaccrcf { get; set; }
        public Nullable<double> so_dtladj_exaccrc { get; set; }
        public Nullable<double> so_dtladj_exaccrcp { get; set; }
        public Nullable<double> so_dtladj_valaccr { get; set; }
        public short so_dtladj_grossf { get; set; }
        public short so_dtladj_appseq { get; set; }
        public string pc_pcomp_key { get; set; }
        public double so_dtladj_vatc { get; set; }
        public double so_dtladj_vatcf { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public short so_dtladj_incicprcf { get; set; }
        public string en_vend_key { get; set; }
        public short so_dtladj_compforf { get; set; }
    }
}
