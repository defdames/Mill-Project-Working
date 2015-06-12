namespace Mill_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sf_plant_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string sf_plant_key { get; set; }

        [Required]
        [StringLength(30)]
        public string sf_plant_name { get; set; }

        [Required]
        [StringLength(30)]
        public string sf_plant_adr1 { get; set; }

        [Required]
        [StringLength(30)]
        public string sf_plant_adr2 { get; set; }

        [Required]
        [StringLength(10)]
        public string sf_plant_postc { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_city { get; set; }

        [Required]
        [StringLength(10)]
        public string sf_plant_state { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_cntry { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_tel { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_fax { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_cont { get; set; }

        [Required]
        [StringLength(20)]
        public string sf_plant_telex { get; set; }

        [Required]
        [StringLength(4)]
        public string sf_plant_defwh { get; set; }

        [Required]
        [StringLength(10)]
        public string sf_wdays_key { get; set; }

        public double sf_plant_sdthr { get; set; }

        [Required]
        [StringLength(8)]
        public string sa_user_key { get; set; }

        public DateTime? en_plant_crtdt { get; set; }

        public DateTime? en_plant_chgdt { get; set; }

        public int sf_plant_advschf { get; set; }

        public short sf_plant_prdtmbkt { get; set; }

        [Required]
        [StringLength(2)]
        public string gl_bkcd_key { get; set; }

        [Required]
        [StringLength(40)]
        public string sf_plant_sact { get; set; }

        [StringLength(38)]
        public string gl_bunit_key { get; set; }

        [Required]
        [StringLength(40)]
        public string sf_plant_rvdadjac { get; set; }

        [Required]
        [StringLength(40)]
        public string sf_plant_rvoadjac { get; set; }

        [Required]
        [StringLength(40)]
        public string sf_plant_mvadjac { get; set; }

        public short sf_plant_autprdtnf { get; set; }

        public short sf_plant_defqty { get; set; }

        [StringLength(250)]
        public string sf_lotfrmt_key { get; set; }

        public int sf_plant_upcnt { get; set; }

        [Required]
        [StringLength(10)]
        public string sf_mfgrp_key { get; set; }

        public double? sf_plant_cmplttolr { get; set; }

        public short sf_plant_deptreqf { get; set; }
    }
}
