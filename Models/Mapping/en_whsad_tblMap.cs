using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_whsad_tblMap : EntityTypeConfiguration<en_whsad_tbl>
    {
        public en_whsad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_whs_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.im_adrtp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_whsad_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            // Table & Column Mappings
            this.ToTable("en_whsad_tbl");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_whsad_crtdt).HasColumnName("en_whsad_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_whsad_cmnts).HasColumnName("en_whsad_cmnts");
            this.Property(t => t.en_whsad_chgdt).HasColumnName("en_whsad_chgdt");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
        }
    }
}
