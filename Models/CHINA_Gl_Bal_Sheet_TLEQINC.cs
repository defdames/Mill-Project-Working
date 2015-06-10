using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_Gl_Bal_Sheet_TLEQINC
    {
        public string Acct { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string AcctDesc { get; set; }
        public string gl_acct_dbcrf { get; set; }
        public Nullable<short> PeriorYR { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<double> PdBalOpen { get; set; }
        public string TypeDesc { get; set; }
        public string ClassDes { get; set; }
        public string AcctSort { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
