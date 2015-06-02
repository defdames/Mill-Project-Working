namespace Mill_Project.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gl_cmp_tbl
    {
        [Key]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Required]
        [StringLength(30)]
        public string gl_cmp_desc { get; set; }

        [Required]
        [StringLength(30)]
        public string gl_cmp_adr1 { get; set; }

        [Required]
        [StringLength(30)]
        public string gl_cmp_adr2 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_city { get; set; }

        [Required]
        [StringLength(10)]
        public string gl_cmp_state { get; set; }

        [Required]
        [StringLength(10)]
        public string gl_cmp_postc { get; set; }

        [Required]
        [StringLength(20)]
        public string en_cntry_key { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_tel { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_fax { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_telex { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_cont1 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_posn1 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_cont2 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_posn2 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_cont3 { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_posn3 { get; set; }

        [Required]
        [StringLength(10)]
        public string gl_cmp_acnno { get; set; }

        [Required]
        [StringLength(3)]
        public string gl_crncy_key { get; set; }

        [Required]
        [StringLength(40)]
        public string gl_cmp_retac { get; set; }

        [Required]
        [StringLength(40)]
        public string gl_cmp_ppsac { get; set; }

        [Required]
        [StringLength(40)]
        public string gl_cmp_rndac { get; set; }

        [Required]
        [StringLength(15)]
        public string gl_cmp_taxfn { get; set; }

        [Required]
        [StringLength(4)]
        public string gl_cmp_defbr { get; set; }

        [Required]
        [StringLength(4)]
        public string gl_cmp_defpl { get; set; }

        public int gl_cmp_onebr { get; set; }

        public int gl_cmp_onepl { get; set; }

        [Required]
        [StringLength(2)]
        public string gl_cmp_parnt { get; set; }

        public int gl_cmp_upcnt { get; set; }

        [Required]
        [StringLength(8)]
        public string sa_user_key { get; set; }

        public DateTime gl_cmp_chgdt { get; set; }

        public DateTime gl_cmp_crtdt { get; set; }

        public short gl_cmp_wtmsf { get; set; }

        public double gl_cmp_posttol { get; set; }

        public short gl_cmp_taxenv { get; set; }

        public short gl_cmp_opt3 { get; set; }

        [Required]
        [StringLength(3)]
        public string gl_cmp_cur3 { get; set; }

        public short gl_cmp_taxcalc { get; set; }

        public short gl_cmp_recalc { get; set; }

        public short gl_cmp_taxincl { get; set; }

        [Required]
        [StringLength(20)]
        public string gl_cmp_vatreg { get; set; }

        [Required]
        [StringLength(25)]
        public string gl_cmp_exon { get; set; }

        public short gl_vatcd_qlf { get; set; }

        [Required]
        [StringLength(10)]
        public string gl_vatcd_key { get; set; }

        public double gl_cmp_lmtamtc { get; set; }

        public DateTime? gl_cmp_lmtdt { get; set; }

        public double gl_cmp_ytdlmtc { get; set; }

        [StringLength(10)]
        public string en_mfrid_key { get; set; }

        public double gl_cmp_crdttol { get; set; }

        public short gl_cmp_crdttolf { get; set; }

        [Required]
        [StringLength(2)]
        public string gl_bkcd_key { get; set; }

        [Required]
        [StringLength(2)]
        public string en_uom_wgt { get; set; }

        [Required]
        [StringLength(2)]
        public string en_uom_vol { get; set; }

        public short gl_cmp_pctolbasis { get; set; }

        public double? gl_cmp_pcundtol { get; set; }

        public double? gl_cmp_pcovrtol { get; set; }

        [StringLength(2)]
        public string en_uom_key { get; set; }

        public short gl_cmp_enhprcf { get; set; }

        [Required]
        [StringLength(40)]
        public string gl_acct_susp { get; set; }

        [Required]
        [StringLength(40)]
        public string gl_acct_cdvadj { get; set; }

        public double gl_cmp_adjlimit { get; set; }

        public double? gl_cmp_csttol { get; set; }

        [Required]
        [StringLength(10)]
        public string gl_cmp_adjreason { get; set; }

        [StringLength(13)]
        public string gl_cmp_gln { get; set; }

        public short gl_cmp_csttoltyp { get; set; }

        [StringLength(20)]
        public string gl_cmp_hazmattel { get; set; }

        [StringLength(50)]
        public string gl_cmp_hazmatshipername { get; set; }

        [StringLength(100)]
        public string gl_cmp_hazmatshipertitle { get; set; }

        [StringLength(250)]
        public string gl_cmp_dlotfrmt { get; set; }

        [StringLength(250)]
        public string gl_cmp_plotfrmt { get; set; }

        [StringLength(250)]
        public string gl_cmp_mlotfrmt { get; set; }
    }
}
