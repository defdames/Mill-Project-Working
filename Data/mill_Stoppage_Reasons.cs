namespace Mill_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mill_Stoppage_Reasons
    {
        [Key]
        public int Stoppage_Reasons_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Stop_Reason { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

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
