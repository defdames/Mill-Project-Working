using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_GL_Inc_NewCostsales
    {
        public string Type { get; set; }
        public string Class { get; set; }
        public string shortacct { get; set; }
        public string AcctDesc { get; set; }
        public string Deb_Cred { get; set; }
        public Nullable<short> PeriodYR { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<double> PdBalOpen { get; set; }
        public string ClassDesc { get; set; }
        public string TypeDesc { get; set; }
        public int htype { get; set; }
        public int htype1 { get; set; }
        public int htype2 { get; set; }
        public int htype3 { get; set; }
        public string Acct { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
