namespace Mill_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sa_uentp_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string sa_user_key { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string sa_uentp_entyp { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string sa_uentp_entid { get; set; }

        public int sa_uentp_upcnt { get; set; }
    }
}
