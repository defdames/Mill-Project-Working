using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class web_sa_group_tbl
    {
        public web_sa_group_tbl()
        {
            this.web_sa_report_tbl = new List<web_sa_report_tbl>();
            this.web_sa_user_tbl = new List<web_sa_user_tbl>();
        }

        public string sa_group_key { get; set; }
        public string sa_group_desc { get; set; }
        public virtual ICollection<web_sa_report_tbl> web_sa_report_tbl { get; set; }
        public virtual ICollection<web_sa_user_tbl> web_sa_user_tbl { get; set; }
    }
}
