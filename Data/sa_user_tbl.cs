namespace Mill_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sa_user_tbl
    {
        [Key]
        [StringLength(8)]
        public string sa_user_key { get; set; }

        [Required]
        [StringLength(32)]
        public string sa_user_paswd { get; set; }

        [Required]
        [StringLength(30)]
        public string sa_user_name { get; set; }

        [Required]
        [StringLength(30)]
        public string sa_user_adr1 { get; set; }

        [Required]
        [StringLength(30)]
        public string sa_user_adr2 { get; set; }

        [Required]
        [StringLength(20)]
        public string sa_user_city { get; set; }

        [Required]
        [StringLength(10)]
        public string sa_user_state { get; set; }

        [Required]
        [StringLength(10)]
        public string sa_user_postc { get; set; }

        [Required]
        [StringLength(20)]
        public string sa_user_tel { get; set; }

        [Required]
        [StringLength(20)]
        public string sa_user_fax { get; set; }

        [Required]
        [StringLength(2)]
        public string gl_cmp_key { get; set; }

        [Required]
        [StringLength(4)]
        public string sa_user_defbr { get; set; }

        [Required]
        [StringLength(4)]
        public string sa_user_defpt { get; set; }

        [Required]
        [StringLength(4)]
        public string sa_user_defwh { get; set; }

        public DateTime? sa_user_lastlogin { get; set; }

        [Required]
        [StringLength(32)]
        public string sa_user_deffr { get; set; }

        public DateTime sa_user_strdt { get; set; }

        public DateTime sa_user_enddt { get; set; }

        public short sa_user_loginframe { get; set; }

        [StringLength(32)]
        public string sa_osuser_key { get; set; }

        public short sa_user_webf { get; set; }

        public short sa_user_desktopf { get; set; }

        [StringLength(60)]
        public string sa_user_email { get; set; }

        [Required]
        [StringLength(32)]
        public string sa_user_ceuser { get; set; }

        [Required]
        [StringLength(32)]
        public string sa_user_cepaswd { get; set; }

        [StringLength(30)]
        public string sa_user_colorset { get; set; }

        public short sa_user_enticnf { get; set; }

        public int sa_user_upcnt { get; set; }

        [StringLength(40)]
        public string sa_user_loginname { get; set; }

        [Required]
        [StringLength(32)]
        public string sa_user_sgid { get; set; }

        [StringLength(10)]
        public string en_role_key { get; set; }

        public int sa_user_options { get; set; }

        public short sa_user_locked { get; set; }

        public DateTime? sa_user_apprinadt { get; set; }

        public short sa_user_skipapprf { get; set; }

        [StringLength(8)]
        public string sa_user_manager { get; set; }

        [StringLength(8)]
        public string sa_user_newappr { get; set; }

        public short? sa_user_chngpwd { get; set; }
    }
}
