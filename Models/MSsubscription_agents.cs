using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsubscription_agents
    {
        public int id { get; set; }
        public string publisher { get; set; }
        public string publisher_db { get; set; }
        public string publication { get; set; }
        public int subscription_type { get; set; }
        public string queue_id { get; set; }
        public byte update_mode { get; set; }
        public bool failover_mode { get; set; }
        public int spid { get; set; }
        public System.DateTime login_time { get; set; }
        public bool allow_subscription_copy { get; set; }
        public int attach_state { get; set; }
        public byte[] attach_version { get; set; }
        public Nullable<int> last_sync_status { get; set; }
        public string last_sync_summary { get; set; }
        public Nullable<System.DateTime> last_sync_time { get; set; }
        public string queue_server { get; set; }
    }
}
