using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_igdout_ext
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string sf_ingrd_key { get; set; }
        public short sf_opseq_key { get; set; }
        public string aa_initials_key { get; set; }
        public Nullable<int> an_dumps_key { get; set; }
        public string ab_system_key { get; set; }
        public string ad_press_key { get; set; }
        public string ag_compressor_key { get; set; }
        public string ah_air_key { get; set; }
        public string ao_pressure_key { get; set; }
        public string ap_pressure_key { get; set; }
        public string aq_pressure_key { get; set; }
        public double ae_grindhrs_key { get; set; }
        public double af_millhrs_key { get; set; }
        public int ac_mills_key { get; set; }
        public Nullable<int> ar_recvarwash_key { get; set; }
        public int pm_igdout_upcnt { get; set; }
    }
}
