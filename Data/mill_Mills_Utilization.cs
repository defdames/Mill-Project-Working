namespace Mill_Project.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mill_Mills_Utilization
    {
        [Key]
        public int Mills_Utilization_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Mill_ID { get; set; }

        [StringLength(255)]
        public string System { get; set; }

        [StringLength(255)]
        public string RunCode { get; set; }

        public DateTime? Start_Time { get; set; }

        public DateTime? Stop_Time { get; set; }

        [Required]
        [StringLength(255)]
        public string Shift { get; set; }

        public DateTime? Shift_Start_Date { get; set; }

        public DateTime? Shift_Stop_Date { get; set; }

        [StringLength(20)]
        public string sa_user_key { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        public int? SO_Number { get; set; }

        [StringLength(255)]
        public string Item_Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Shift_Category { get; set; }

        public int? Mill_temp { get; set; }

        public int? D10 { get; set; }

        public int? D50 { get; set; }

        public int? D90 { get; set; }

        public int? D98 { get; set; }

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
