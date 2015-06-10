using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_load_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_whs_key { get; set; }
        public string so_load_key { get; set; }
        public System.DateTime so_ship_date { get; set; }
        public string en_carr_key { get; set; }
        public string en_loadpf_key { get; set; }
        public string en_mode_key { get; set; }
        public string en_service_key { get; set; }
        public string so_load_ref { get; set; }
        public short so_load_state { get; set; }
        public string so_load_appttm { get; set; }
        public Nullable<double> so_load_actwt { get; set; }
        public string so_load_awtuom { get; set; }
        public Nullable<double> so_load_estwt { get; set; }
        public string so_load_ewtuom { get; set; }
        public Nullable<double> so_load_eqwt { get; set; }
        public Nullable<double> so_load_leqwt { get; set; }
        public string so_load_railct { get; set; }
        public string so_load_rout { get; set; }
        public string so_load_pronum { get; set; }
        public short so_load_drctf { get; set; }
        public short so_load_carrf { get; set; }
        public int im_localgrp_key { get; set; }
        public string so_load_vechid { get; set; }
        public string so_load_trailerid { get; set; }
        public short so_load_avouchf { get; set; }
        public string so_load_routedesc { get; set; }
        public int so_load_upcnt { get; set; }
        public string so_load_msgtext { get; set; }
        public string gl_cmp_assoc { get; set; }
        public string in_whs_assoc { get; set; }
        public string so_load_assoc { get; set; }
        public string en_carr_orig { get; set; }
        public string en_carr_chgby { get; set; }
        public Nullable<System.DateTime> en_carr_chgdt { get; set; }
    }
}
