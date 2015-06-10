using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class BGL_Department
    {
        public string Type { get; set; }
        public string Class { get; set; }
        public string Acct { get; set; }
        public string AcctDesc { get; set; }
        public string Deb_Cred { get; set; }
        public Nullable<int> PeriodYR { get; set; }
        public short PeriodID { get; set; }
        public Nullable<double> PdBalAmt { get; set; }
        public Nullable<double> PdBalOpen { get; set; }
        public string ClassDesc { get; set; }
        public string TypeDesc { get; set; }
        public string RTYPE { get; set; }
        public string gl_class_key2 { get; set; }
        public int hdept { get; set; }
        public string bname { get; set; }
        public string gl_class_key5 { get; set; }
    }
}
