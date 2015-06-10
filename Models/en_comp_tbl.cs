using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_comp_tbl
    {
        public string en_comp_key { get; set; }
        public string en_comp_name { get; set; }
        public int en_comp_holdf { get; set; }
        public string en_stats_key { get; set; }
        public int en_comp_fstat { get; set; }
        public Nullable<System.DateTime> en_comp_crddt { get; set; }
        public System.DateTime en_comp_chgdt { get; set; }
        public string sa_user_key { get; set; }
        public double en_comp_clmtc { get; set; }
        public double en_comp_stdsc { get; set; }
        public string en_comp_remk { get; set; }
        public string en_comp_catgy { get; set; }
        public string en_sicc_key { get; set; }
        public int en_comp_empls { get; set; }
        public double en_comp_tovrc { get; set; }
        public double en_comp_proft { get; set; }
        public string en_corp_key { get; set; }
        public System.DateTime en_comp_crtdt { get; set; }
        public Nullable<double> en_comp_crdtlimit { get; set; }
        public Nullable<short> en_comp_crdtlmtwng { get; set; }
        public string en_comp_crdtrep { get; set; }
        public string en_riskcode_key { get; set; }
        public string en_comp_dbnumber { get; set; }
        public string en_comp_dbrating { get; set; }
        public Nullable<System.DateTime> en_comp_lcrdtrevdt { get; set; }
        public short en_comp_incrdtmgtf { get; set; }
        public string en_comp_crdtcrncy { get; set; }
        public Nullable<double> en_comp_crdtexp { get; set; }
        public Nullable<System.DateTime> en_comp_crdtexpdt { get; set; }
        public Nullable<System.DateTime> en_comp_ncrdtrevdt { get; set; }
        public string en_comp_holdresn { get; set; }
        public Nullable<System.DateTime> en_comp_holdefctdt { get; set; }
        public int en_comp_upcnt { get; set; }
        public string en_comp_ccaudit { get; set; }
    }
}
