using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class MSsnapshotdeliveryprogress
    {
        public string session_token { get; set; }
        public int progress_token_hash { get; set; }
        public string progress_token { get; set; }
        public Nullable<System.DateTime> progress_timestamp { get; set; }
    }
}
