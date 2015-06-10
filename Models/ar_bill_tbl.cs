using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_bill_tbl
    {
        public string gl_cmp_key { get; set; }
        public string ar_bill_key { get; set; }
        public double ar_bill_depc { get; set; }
        public Nullable<double> ar_bill_clmtc { get; set; }
        public double ar_bill_lstpc { get; set; }
        public string ap_bank_key { get; set; }
        public string ap_bank_acctno { get; set; }
        public string ar_bill_tacct { get; set; }
        public string ar_bill_dacct { get; set; }
        public string en_stats_key { get; set; }
        public short ar_bill_fstat { get; set; }
        public short ar_bill_bilcy { get; set; }
        public short ar_bill_stmtp { get; set; }
        public short ar_bill_dunte { get; set; }
        public Nullable<System.DateTime> ar_bill_stmdt { get; set; }
        public Nullable<System.DateTime> ar_bill_lpddt { get; set; }
        public double ar_bill_unpdc { get; set; }
        public double ar_bill_fchgc { get; set; }
        public string ar_bill_remk { get; set; }
        public string ar_tax_key { get; set; }
        public string gl_crncy_key { get; set; }
        public string ar_bill_crdno { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime ar_bill_chgdt { get; set; }
        public System.DateTime ar_bill_crtdt { get; set; }
        public string ar_bill_name { get; set; }
        public string ar_terms_key { get; set; }
        public string ar_bill_catgy { get; set; }
        public short ar_bill_holdf { get; set; }
        public short ar_bill_avgdp { get; set; }
        public Nullable<short> ar_bill_autoinv { get; set; }
        public int ar_bill_stdte { get; set; }
        public short ar_bill_stmtf { get; set; }
        public int ar_bill_taxf { get; set; }
        public string ar_bill_exemno { get; set; }
        public System.DateTime ar_bill_exemdt { get; set; }
        public string en_frgt_key { get; set; }
        public int ar_bill_upcnt { get; set; }
        public int ar_bill_dunflag { get; set; }
        public int en_lang_key { get; set; }
        public string ar_duncyc_key { get; set; }
        public Nullable<System.DateTime> ar_bill_lastdundt { get; set; }
        public string gl_paycd_key { get; set; }
        public string gl_doccd_key { get; set; }
        public short ar_bill_curf { get; set; }
        public string ar_bill_regid { get; set; }
        public short ar_bill_type { get; set; }
        public short gl_vatcd_qlf { get; set; }
        public string gl_vatcd_key { get; set; }
        public short ar_bill_declp { get; set; }
        public string ar_bill_exsus { get; set; }
        public double ar_bill_lmtamtc { get; set; }
        public Nullable<System.DateTime> ar_bill_lmtdt { get; set; }
        public double ar_bill_ytdlmtc { get; set; }
        public double ar_bill_nodrftc { get; set; }
        public double ar_bill_nodrftcf { get; set; }
        public short ar_bill_padraft { get; set; }
        public string ar_bill_intvndno { get; set; }
        public short ar_bill_crdttolf { get; set; }
        public Nullable<short> ar_bill_crdtlmtwng { get; set; }
        public string ar_bill_crdtrep { get; set; }
        public string en_riskcode_key { get; set; }
        public short ar_bill_pstdueamtf { get; set; }
        public Nullable<double> ar_bill_pstdueamt { get; set; }
        public Nullable<short> ar_bill_pstduedays { get; set; }
        public short ar_bill_pstdueprdf { get; set; }
        public Nullable<double> ar_bill_maxordramt { get; set; }
        public string ar_bill_holdresn { get; set; }
        public Nullable<System.DateTime> ar_bill_holdefctdt { get; set; }
        public Nullable<System.DateTime> ar_bill_lcrdtrevdt { get; set; }
        public Nullable<System.DateTime> ar_bill_ncrdtrevdt { get; set; }
        public short ar_bill_incdisitmf { get; set; }
        public short ar_bill_incrdtmgtf { get; set; }
        public string ar_bill_crdtcrncy { get; set; }
        public Nullable<double> ar_bill_crdtexp { get; set; }
        public Nullable<System.DateTime> ar_bill_crdtexpdt { get; set; }
        public Nullable<double> ar_bill_crdttol { get; set; }
        public Nullable<int> ar_bill_manualf { get; set; }
        public string ar_bill_ccaudit { get; set; }
        public string gl_bkcd_key { get; set; }
        public string ar_paygrp_key { get; set; }
        public Nullable<int> ar_bill_dfltbk { get; set; }
        public string gl_cmp_recv { get; set; }
        public string ar_bill_cmtacct { get; set; }
        public Nullable<int> en_vatmthd_key { get; set; }
        public string ar_ivdelcd_key { get; set; }
    }
}
