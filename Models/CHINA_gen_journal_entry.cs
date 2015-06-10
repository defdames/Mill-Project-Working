using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CHINA_gen_journal_entry
    {
        public int JournalEntry { get; set; }
        public Nullable<int> PerYr { get; set; }
        public Nullable<int> PerMo { get; set; }
        public System.DateTime PostDate { get; set; }
        public string EntryDesc { get; set; }
        public string AcctKey { get; set; }
        public Nullable<double> Amt { get; set; }
        public string PostedBy { get; set; }
        public short Type { get; set; }
        public short Line { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public string gl_cmp_key { get; set; }
    }
}
