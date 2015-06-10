using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class BGL_Inc_NewOtherinc
    {
        public string Type { get; set; }
        public string Class { get; set; }
        public string ShortAcct { get; set; }
        public string AcctDesc { get; set; }
        public string Deb_Cred { get; set; }
        public Nullable<int> PeriodYR { get; set; }
        public Nullable<short> PeriodID { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<double> PdBalOpen { get; set; }
        public string ClassDesc { get; set; }
        public string TypeDesc { get; set; }
        public string AcctSort { get; set; }
        public string Acct { get; set; }
        public string Rtype { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
