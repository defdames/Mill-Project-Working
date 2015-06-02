namespace Mill_Project.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_sa_user_tbl
    {
        [Key]
        [StringLength(20)]
        public string sa_user_key { get; set; }

        [StringLength(30)]
        public string sa_user_name { get; set; }
    }
}
