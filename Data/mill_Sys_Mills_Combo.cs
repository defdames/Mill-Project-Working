namespace Mill_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mill_Sys_Mills_Combo
    {
        [Key]
        public int Sys_Mills_Combo_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string System { get; set; }

        [Required]
        [StringLength(255)]
        public string Mill_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string Active { get; set; }

        [Required]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Required]
        [StringLength(4)]
        public string sf_plant_key { get; set; }

        public DateTime? Created_date { get; set; }

        public DateTime? Modified_date { get; set; }

        [StringLength(255)]
        public string Created_by { get; set; }

        [StringLength(255)]
        public string Modified_by { get; set; }
    }
}
