using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_bill_tbl
    {
        public string en_bill_key { get; set; }
        public int en_bill_upcnt { get; set; }
        public string en_cust_key { get; set; }
        public string en_bill_name { get; set; }
        public short en_bill_dunte { get; set; }
        public System.DateTime en_bill_chgdt { get; set; }
        public double en_bill_fchgc { get; set; }
        public Nullable<double> en_bill_clmtc { get; set; }
        public string en_bank_key { get; set; }
        public string en_bank_acctno { get; set; }
        public string en_bill_remk { get; set; }
        public string en_tax_key { get; set; }
        public string en_bill_rslen { get; set; }
        public string en_terms_key { get; set; }
        public string en_bill_catgy { get; set; }
        public int en_bill_taxf { get; set; }
        public short en_bill_holdf { get; set; }
        public string en_stats_key { get; set; }
        public short en_bill_fstat { get; set; }
        public short en_bill_bilcy { get; set; }
        public short en_bill_stmtp { get; set; }
        public System.DateTime en_bill_crtdt { get; set; }
        public string en_crncy_key { get; set; }
        public string en_comp_key { get; set; }
        public string en_bill_cmnts { get; set; }
        public string sa_user_key { get; set; }
        public string en_bill_bkact { get; set; }
        public string en_bill_dbrtg { get; set; }
        public string en_bill_dbno { get; set; }
        public short en_bill_avgdp { get; set; }
        public short en_bill_intf { get; set; }
        public double en_bill_tlamt { get; set; }
        public int en_bill_toltp { get; set; }
        public double en_bill_unpdc { get; set; }
        public double en_bill_avilc { get; set; }
        public double en_bill_depc { get; set; }
        public double en_bill_ordrc { get; set; }
        public double en_bill_lstpc { get; set; }
        public double en_bill_stdsc { get; set; }
        public string en_bill_tacct { get; set; }
        public string en_bill_dacct { get; set; }
        public string en_frgt_key { get; set; }
        public int en_lang_key { get; set; }
        public short en_bill_curf { get; set; }
        public string en_paycd_key { get; set; }
        public string en_doccd_key { get; set; }
        public string en_bill_intvndno { get; set; }
        public Nullable<short> en_bill_crdtlmtwng { get; set; }
        public string en_bill_crdtrep { get; set; }
        public string en_riskcode_key { get; set; }
        public short en_bill_pstdueamtf { get; set; }
        public Nullable<double> en_bill_pstdueamt { get; set; }
        public Nullable<short> en_bill_pstduedays { get; set; }
        public short en_bill_pstdueprdf { get; set; }
        public Nullable<double> en_bill_maxordramt { get; set; }
        public string en_bill_holdresn { get; set; }
        public Nullable<System.DateTime> en_bill_holdefctdt { get; set; }
        public Nullable<System.DateTime> en_bill_lcrdtrevdt { get; set; }
        public Nullable<System.DateTime> en_bill_ncrdtrevdt { get; set; }
        public short en_bill_incrdtmgtf { get; set; }
        public string en_bill_crdtcrncy { get; set; }
        public short en_bill_incdisitmf { get; set; }
        public Nullable<double> en_bill_crdtexp { get; set; }
        public Nullable<System.DateTime> en_bill_crdtexpdt { get; set; }
        public string en_bill_ccaudit { get; set; }
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string en_paygrp_key { get; set; }
    }
}
