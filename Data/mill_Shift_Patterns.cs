namespace Mill_Project.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mill_Shift_Patterns
    {
        [Key]
        public int Shift_Patterns_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Shift_ID { get; set; }

        public int? Shift_Length_Hours { get; set; }

        public DateTime Shift_Start_Time { get; set; }

        public DateTime Shift_Stop_Time { get; set; }

        [Required]
        [StringLength(1)]
        public string Shift_Active { get; set; }

        [Column(TypeName = "text")]
        public string Comment { get; set; }

        [Required]
        [StringLength(1)]
        public string Shift_Hours_Cross_Days { get; set; }

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
