using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSreplication_subscriptions
    {
        public string publisher { get; set; }
        public string publisher_db { get; set; }
        public string publication { get; set; }
        public bool independent_agent { get; set; }
        public int subscription_type { get; set; }
        public string distribution_agent { get; set; }
        public System.DateTime time { get; set; }
        public string description { get; set; }
        public byte[] transaction_timestamp { get; set; }
        public byte update_mode { get; set; }
        public byte[] agent_id { get; set; }
        public byte[] subscription_guid { get; set; }
        public byte[] subid { get; set; }
        public bool immediate_sync { get; set; }
    }
}
