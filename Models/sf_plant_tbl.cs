using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class sf_plant_tbl
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string sf_plant_name { get; set; }
        public string sf_plant_adr1 { get; set; }
        public string sf_plant_adr2 { get; set; }
        public string sf_plant_postc { get; set; }
        public string sf_plant_city { get; set; }
        public string sf_plant_state { get; set; }
        public string sf_plant_cntry { get; set; }
        public string sf_plant_tel { get; set; }
        public string sf_plant_fax { get; set; }
        public string sf_plant_cont { get; set; }
        public string sf_plant_telex { get; set; }
        public string sf_plant_defwh { get; set; }
        public string sf_wdays_key { get; set; }
        public double sf_plant_sdthr { get; set; }
        public string sa_user_key { get; set; }
        public Nullable<System.DateTime> en_plant_crtdt { get; set; }
        public Nullable<System.DateTime> en_plant_chgdt { get; set; }
        public int sf_plant_advschf { get; set; }
        public short sf_plant_prdtmbkt { get; set; }
        public string gl_bkcd_key { get; set; }
        public string sf_plant_sact { get; set; }
        public string gl_bunit_key { get; set; }
        public string sf_plant_rvdadjac { get; set; }
        public string sf_plant_rvoadjac { get; set; }
        public string sf_plant_mvadjac { get; set; }
        public short sf_plant_autprdtnf { get; set; }
        public short sf_plant_defqty { get; set; }
        public string sf_lotfrmt_key { get; set; }
        public int sf_plant_upcnt { get; set; }
        public string sf_mfgrp_key { get; set; }
        public Nullable<double> sf_plant_cmplttolr { get; set; }
        public short sf_plant_deptreqf { get; set; }
    }
}
