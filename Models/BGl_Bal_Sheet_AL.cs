using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class BGl_Bal_Sheet_AL
    {
        public string Acct { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string AcctDesc { get; set; }
        public string gl_acct_dbcrf { get; set; }
        public Nullable<int> PeriorYR { get; set; }
        public Nullable<short> PeriodID { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<double> PdBalOpen { get; set; }
        public string TypeDesc { get; set; }
        public string ClassDes { get; set; }
        public string AcctSort { get; set; }
        public string Rtype { get; set; }
    }
}
