using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsubscription_properties
    {
        public string publisher { get; set; }
        public string publisher_db { get; set; }
        public string publication { get; set; }
        public int publication_type { get; set; }
        public string publisher_login { get; set; }
        public string publisher_password { get; set; }
        public int publisher_security_mode { get; set; }
        public string distributor { get; set; }
        public string distributor_login { get; set; }
        public string distributor_password { get; set; }
        public int distributor_security_mode { get; set; }
        public string ftp_address { get; set; }
        public Nullable<int> ftp_port { get; set; }
        public string ftp_login { get; set; }
        public string ftp_password { get; set; }
        public string alt_snapshot_folder { get; set; }
        public string working_directory { get; set; }
        public bool use_ftp { get; set; }
        public string dts_package_name { get; set; }
        public string dts_package_password { get; set; }
        public int dts_package_location { get; set; }
        public bool enabled_for_syncmgr { get; set; }
        public bool offload_agent { get; set; }
        public string offload_server { get; set; }
        public string dynamic_snapshot_location { get; set; }
        public bool use_web_sync { get; set; }
        public string internet_url { get; set; }
        public string internet_login { get; set; }
        public string internet_password { get; set; }
        public int internet_security_mode { get; set; }
        public int internet_timeout { get; set; }
        public string hostname { get; set; }
        public string publisherlink { get; set; }
        public string publisherlinkuser { get; set; }
        public Nullable<System.Guid> job_step_uid { get; set; }
    }
}
