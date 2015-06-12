using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_prcss_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_prcss_key { get; set; }
        public int sf_prcss_ver { get; set; }
        public string sf_frmla_key { get; set; }
        public short sf_frmla_ver { get; set; }
        public string sf_rout_key { get; set; }
        public string sf_prcss_desc { get; set; }
        public string sf_prcss_stat { get; set; }
        public short sf_prcss_advplnf { get; set; }
        public short sf_prcss_advschf { get; set; }
        public int sf_prcss_pstpver { get; set; }
        public string in_locgrp_key { get; set; }
        public string in_whs_key { get; set; }
        public string sf_prcss_astplid { get; set; }
        public int sf_prcss_upcnt { get; set; }
    }
}
