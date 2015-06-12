using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_rmtad_tblMap : EntityTypeConfiguration<en_rmtad_tbl>
    {
        public en_rmtad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_remt_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adrtp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_rmtad_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_rmtad_tbl");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_rmtad_cmnts).HasColumnName("en_rmtad_cmnts");
            this.Property(t => t.en_rmtad_crtdt).HasColumnName("en_rmtad_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_rmtad_chgdt).HasColumnName("en_rmtad_chgdt");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
            this.Property(t => t.en_rmtad_primaryf).HasColumnName("en_rmtad_primaryf");
        }
    }
}
