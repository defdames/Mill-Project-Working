using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class web_sa_report_version_tbl
    {
        public web_sa_report_version_tbl()
        {
            this.web_sa_report_tbl = new List<web_sa_report_tbl>();
        }

        public string sa_report_version { get; set; }
        public string sa_report_version_desc { get; set; }
        public virtual ICollection<web_sa_report_tbl> web_sa_report_tbl { get; set; }
    }
}
