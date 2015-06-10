using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_recpt_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_recpt_key { get; set; }
        public string po_hdr_key { get; set; }
        public Nullable<System.DateTime> po_recpt_shpdt { get; set; }
        public System.DateTime po_recpt_recdt { get; set; }
        public string po_recpt_shpco { get; set; }
        public string po_recpt_methd { get; set; }
        public string po_recpt_mnfst { get; set; }
        public string po_recpt_bolno { get; set; }
        public string po_recpt_shprf { get; set; }
        public string po_recpt_recby { get; set; }
        public string po_recpt_remk { get; set; }
        public int po_recpt_boxs { get; set; }
        public double po_recpt_wght { get; set; }
        public string po_recpt_wtuom { get; set; }
        public System.DateTime po_recpt_chgdt { get; set; }
        public System.DateTime po_recpt_crtdt { get; set; }
        public double po_recpt_rate { get; set; }
        public string sa_user_key { get; set; }
        public short po_recpt_frmth { get; set; }
        public short po_recpt_eustatf { get; set; }
        public Nullable<System.DateTime> po_recpt_eustatdt { get; set; }
        public string en_fob_key { get; set; }
        public string en_trnsport_key { get; set; }
        public int po_recpt_upcnt { get; set; }
        public string so_ship_key { get; set; }
        public string gl_cmp_sales { get; set; }
        public string so_brnch_sales { get; set; }
        public string en_carr_key { get; set; }
        public string so_ship_logical { get; set; }
        public Nullable<int> po_unload_key { get; set; }
        public string in_whs_unload { get; set; }
        public string en_mode_key { get; set; }
        public string en_serv_key { get; set; }
        public double po_recpt_tobase { get; set; }
        public double po_recpt_tothird { get; set; }
    }
}
