using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pc_agradj_tbl
    {
        public string gl_cmp_key { get; set; }
        public string pc_agrmt_key { get; set; }
        public short pc_agrhdr_ppcind { get; set; }
        public string pc_agrhdr_prod { get; set; }
        public short pc_agrhdr_key { get; set; }
        public short pc_agrdtl_key { get; set; }
        public string pc_agradj_key { get; set; }
        public short pc_agradj_keytyp { get; set; }
        public int pc_agradj_upcnt { get; set; }
        public System.DateTime pc_agradj_crtdt { get; set; }
        public System.DateTime pc_agradj_chgdt { get; set; }
        public int pc_agradj_seq { get; set; }
        public Nullable<System.DateTime> pc_agradj_ordefdt { get; set; }
        public Nullable<System.DateTime> pc_agradj_ordiadt { get; set; }
        public Nullable<System.DateTime> pc_agradj_shpefdt { get; set; }
        public Nullable<System.DateTime> pc_agradj_shpiadt { get; set; }
        public short pc_agradj_ctuff { get; set; }
        public string pc_agradj_uom { get; set; }
        public short pc_agradj_entcompf { get; set; }
        public string pc_agradj_proc { get; set; }
        public string pc_tmplt_key { get; set; }
        public short pc_agradj_cttyp { get; set; }
        public Nullable<double> pc_agradj_ctval { get; set; }
        public short pc_agradj_cashdisf { get; set; }
        public short pc_agradj_itemizef { get; set; }
        public short pc_agradj_ovrridef { get; set; }
        public short pc_agradj_taxf { get; set; }
        public short pc_agradj_basisf { get; set; }
        public short pc_agradj_addchnf { get; set; }
        public short pc_agradj_credchgf { get; set; }
        public short pc_agradj_manualf { get; set; }
        public short pc_agradj_commf { get; set; }
        public Nullable<double> pc_agradj_examtcf { get; set; }
        public Nullable<double> pc_agradj_examtc { get; set; }
        public Nullable<double> pc_agradj_exaccrcf { get; set; }
        public Nullable<double> pc_agradj_exaccrc { get; set; }
        public Nullable<double> pc_agradj_valaccr { get; set; }
        public short pc_agradj_grossf { get; set; }
        public short pc_agradj_appseq { get; set; }
        public short pc_agradj_incicprcf { get; set; }
        public string en_vend_key { get; set; }
        public short pc_agradj_compforf { get; set; }
    }
}
