using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_misc_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_misc_key { get; set; }
        public string gl_misc_desc { get; set; }
        public string gl_misc_acpay { get; set; }
        public string gl_misc_acrec { get; set; }
        public int gl_misc_upcnt { get; set; }
        public short gl_misc_posof { get; set; }
        public short gl_misc_pagronlf { get; set; }
        public short gl_misc_freightf { get; set; }
        public short gl_misc_taxf { get; set; }
        public string en_1099_key { get; set; }
        public short gl_misc_rollupf { get; set; }
        public string gl_misc_arvat { get; set; }
        public string gl_misc_apvat { get; set; }
        public int gl_misc_aptaxf { get; set; }
        public short gl_misc_execpropcf { get; set; }
        public short gl_misc_execprosof { get; set; }
        public short gl_misc_execproshf { get; set; }
        public short gl_misc_adjvaluet { get; set; }
        public short gl_misc_commf { get; set; }
        public short gl_misc_marginf { get; set; }
        public short gl_misc_posbasrevf { get; set; }
        public string sa_user_key { get; set; }
        public System.DateTime gl_misc_crtdt { get; set; }
        public System.DateTime gl_misc_chgdt { get; set; }
        public short gl_misc_rebatef { get; set; }
        public string gl_acct_paych { get; set; }
        public string gl_acct_rebaccr { get; set; }
        public int gl_misc_arpaychf { get; set; }
        public string en_vend_key { get; set; }
        public string gl_acct_accrexp { get; set; }
        public string gl_acct_accrlia { get; set; }
        public short gl_misc_apprf { get; set; }
        public int gl_misc_whldtaxf { get; set; }
        public string gl_withholdcd_key { get; set; }
    }
}
