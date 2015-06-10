using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vndad_tblMap : EntityTypeConfiguration<en_vndad_tbl>
    {
        public en_vndad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_vend_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adrtp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_vndad_note)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_vndad_tbl");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_vndad_note).HasColumnName("en_vndad_note");
            this.Property(t => t.en_vndad_crtdt).HasColumnName("en_vndad_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_vndad_chgdt).HasColumnName("en_vndad_chgdt");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
            this.Property(t => t.en_vndad_primaryf).HasColumnName("en_vndad_primaryf");
        }
    }
}
