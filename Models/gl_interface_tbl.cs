using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class gl_interface_tbl
    {
        public string gl_cmp_key { get; set; }
        public string gl_interface_entty { get; set; }
        public string gl_interface_entid { get; set; }
        public string gl_interface_srce { get; set; }
        public string gl_interface_docty { get; set; }
        public string gl_interface_docno { get; set; }
        public int gl_interface_seqno { get; set; }
        public string gl_acct_key { get; set; }
        public int sl_dist_key { get; set; }
        public System.DateTime gl_interface_date { get; set; }
        public short gl_interface_postf { get; set; }
        public int gl_interface_upcnt { get; set; }
        public int gl_tran_key { get; set; }
        public string sa_user_key { get; set; }
        public double gl_interface_dbamt { get; set; }
        public double gl_interface_cramt { get; set; }
        public string gl_interface_ref1 { get; set; }
        public string gl_interface_ref2 { get; set; }
        public string gl_interface_ref3 { get; set; }
        public string gl_interface_ref4 { get; set; }
        public string gl_interface_ref5 { get; set; }
        public System.DateTime gl_interface_crtdt { get; set; }
        public int gl_perod_seqno { get; set; }
        public short gl_errcd_key { get; set; }
        public string gl_interface_desc { get; set; }
        public double gl_interface_qty { get; set; }
        public string gl_interface_uom { get; set; }
        public int gl_interface_key { get; set; }
        public short gl_interface_apprv { get; set; }
        public short gl_interface_docln { get; set; }
        public string gl_bkcd_key { get; set; }
        public int gl_bkcd_jnum { get; set; }
        public double gl_intface_dbamtcf { get; set; }
        public double gl_intface_cramtcf { get; set; }
        public string gl_crncy_key { get; set; }
        public double gl_interface_rate { get; set; }
        public double gl_intface_origto3 { get; set; }
        public double gl_intface_tobase { get; set; }
        public Nullable<System.DateTime> gl_intface_asofdt { get; set; }
        public int gl_subpost_key { get; set; }
        public string gl_cmp_orig { get; set; }
        public string gl_intface_origdoc { get; set; }
        public string gl_intface_origent { get; set; }
        public short gl_intface_intcmpf { get; set; }
        public short gl_interface_fctf { get; set; }
        public Nullable<short> gl_pdbal_postf { get; set; }
        public string gl_intface_3rdpart { get; set; }
        public Nullable<int> gl_trace_key { get; set; }
        public string in_whs_key { get; set; }
        public string in_item_key { get; set; }
        public string im_pack_key { get; set; }
        public string so_prod_key { get; set; }
        public Nullable<int> ca_lot_key { get; set; }
        public Nullable<int> Ca_susp_key { get; set; }
        public Nullable<int> ca_susp_prntkey { get; set; }
        public Nullable<int> ca_susplink_key { get; set; }
        public Nullable<int> gl_costing_flag { get; set; }
        public Nullable<int> ca_costgllink_key { get; set; }
        public Nullable<int> ca_costgllink_subtype { get; set; }
        public string gl_invacctgrp_key { get; set; }
        public string so_brand_key { get; set; }
        public string gl_misc_key { get; set; }
    }
}
