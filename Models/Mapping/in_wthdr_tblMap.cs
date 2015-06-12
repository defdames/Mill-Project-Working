using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_wthdr_tblMap : EntityTypeConfiguration<in_wthdr_tbl>
    {
        public in_wthdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_wthdr_towhs, t.in_wthdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_wthdr_frwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_via)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_wthdr_mthd)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_wthdr_contn)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_wthdr_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_wthdr_auth)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_wthdr_urgtf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .HasMaxLength(10);

            this.Property(t => t.in_wthdr_frvatreg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_wthdr_tovatreg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_wthdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.in_wthdr_frwhs).HasColumnName("in_wthdr_frwhs");
            this.Property(t => t.in_wthdr_clsdt).HasColumnName("in_wthdr_clsdt");
            this.Property(t => t.in_wthdr_orddt).HasColumnName("in_wthdr_orddt");
            this.Property(t => t.in_wthdr_prmdt).HasColumnName("in_wthdr_prmdt");
            this.Property(t => t.in_wthdr_prtdt).HasColumnName("in_wthdr_prtdt");
            this.Property(t => t.in_wthdr_reqdt).HasColumnName("in_wthdr_reqdt");
            this.Property(t => t.in_wthdr_expdt).HasColumnName("in_wthdr_expdt");
            this.Property(t => t.in_wthdr_via).HasColumnName("in_wthdr_via");
            this.Property(t => t.in_wthdr_mthd).HasColumnName("in_wthdr_mthd");
            this.Property(t => t.in_wthdr_contn).HasColumnName("in_wthdr_contn");
            this.Property(t => t.in_wthdr_revno).HasColumnName("in_wthdr_revno");
            this.Property(t => t.in_wthdr_remk).HasColumnName("in_wthdr_remk");
            this.Property(t => t.in_wthdr_auth).HasColumnName("in_wthdr_auth");
            this.Property(t => t.in_wthdr_urgtf).HasColumnName("in_wthdr_urgtf");
            this.Property(t => t.in_whitm_tfrtp).HasColumnName("in_whitm_tfrtp");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_wthdr_chgdt).HasColumnName("in_wthdr_chgdt");
            this.Property(t => t.in_wthdr_crtdt).HasColumnName("in_wthdr_crtdt");
            this.Property(t => t.in_wthdr_type).HasColumnName("in_wthdr_type");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.in_wthdr_upcnt).HasColumnName("in_wthdr_upcnt");
            this.Property(t => t.in_wthdr_dmctlf).HasColumnName("in_wthdr_dmctlf");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.in_wthdr_whordf).HasColumnName("in_wthdr_whordf");
            this.Property(t => t.in_wthdr_eustatf).HasColumnName("in_wthdr_eustatf");
            this.Property(t => t.in_wthdr_eustatdt).HasColumnName("in_wthdr_eustatdt");
            this.Property(t => t.in_wthdr_frvatreg).HasColumnName("in_wthdr_frvatreg");
            this.Property(t => t.in_wthdr_tovatreg).HasColumnName("in_wthdr_tovatreg");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.in_wthdr_schshpdt).HasColumnName("in_wthdr_schshpdt");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
        }
    }
}
