using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_shpad_tblMap : EntityTypeConfiguration<en_shpad_tbl>
    {
        public en_shpad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_ship_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.en_shpad_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            // Table & Column Mappings
            this.ToTable("en_shpad_tbl");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_shpad_crtdt).HasColumnName("en_shpad_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_shpad_cmnts).HasColumnName("en_shpad_cmnts");
            this.Property(t => t.en_shpad_chgdt).HasColumnName("en_shpad_chgdt");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
        }
    }
}
