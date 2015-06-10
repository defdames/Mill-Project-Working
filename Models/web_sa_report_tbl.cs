using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class web_sa_report_tbl
    {
        public web_sa_report_tbl()
        {
            this.web_sa_group_tbl = new List<web_sa_group_tbl>();
            this.web_sa_user_tbl = new List<web_sa_user_tbl>();
        }

        public string sa_report_name { get; set; }
        public string sa_report_type { get; set; }
        public string sa_report_description { get; set; }
        public string sa_view_name { get; set; }
        public string sa_notes { get; set; }
        public string sa_paper_type { get; set; }
        public string sa_report_software { get; set; }
        public string sa_importance { get; set; }
        public string sa_active { get; set; }
        public string sa_conversion_status { get; set; }
        public string sa_report_owner { get; set; }
        public Nullable<System.DateTime> sa_report_date_tested { get; set; }
        public string sa_report_results { get; set; }
        public string sa_report_version { get; set; }
        public string sapliveaccess { get; set; }
        public string upgrade { get; set; }
        public string sa_multi_company { get; set; }
        public string sa_report_format { get; set; }
        public Nullable<int> usage_count { get; set; }
        public virtual web_sa_output_type_tbl web_sa_output_type_tbl { get; set; }
        public virtual web_sa_report_software_tbl web_sa_report_software_tbl { get; set; }
        public virtual web_sa_report_type_tbl web_sa_report_type_tbl { get; set; }
        public virtual web_sa_report_version_tbl web_sa_report_version_tbl { get; set; }
        public virtual ICollection<web_sa_group_tbl> web_sa_group_tbl { get; set; }
        public virtual ICollection<web_sa_user_tbl> web_sa_user_tbl { get; set; }
    }
}
