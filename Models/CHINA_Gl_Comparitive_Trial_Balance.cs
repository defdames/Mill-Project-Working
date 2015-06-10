using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_Gl_Comparitive_Trial_Balance
    {
        public string CMP_Key { get; set; }
        public string Acct_Key { get; set; }
        public string AcctDesc { get; set; }
        public string Class_key { get; set; }
        public string Type { get; set; }
        public short Yr { get; set; }
        public int Period { get; set; }
        public double PdOpen { get; set; }
        public Nullable<double> Amt { get; set; }
        public double DAmt { get; set; }
        public double CAmt { get; set; }
        public string DbCr { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
