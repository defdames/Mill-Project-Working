using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pm_shop_ext
    {
        public string gl_cmp_key { get; set; }
        public string sf_plant_key { get; set; }
        public string pm_shop_key { get; set; }
        public string aa_initial_key { get; set; }
        public string ai_mix_key { get; set; }
        public Nullable<double> aj_imixhrs_key { get; set; }
        public Nullable<double> ak_fmixhrs_key { get; set; }
        public Nullable<double> al_tmixhrs_key { get; set; }
        public Nullable<double> am_cycletm_key { get; set; }
        public Nullable<short> an_pckablty_key { get; set; }
        public Nullable<double> ao_filllevel_key { get; set; }
        public Nullable<double> m_testing_ws { get; set; }
        public Nullable<double> m_wash_ws { get; set; }
        public int pm_shop_upcnt { get; set; }
    }
}
