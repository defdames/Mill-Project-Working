namespace Mill_Project.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_sa_cmp_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string sa_user_key { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Column("default")]
        [Required]
        [StringLength(1)]
        public string _default { get; set; }
    }
}
