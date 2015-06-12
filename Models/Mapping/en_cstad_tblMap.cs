using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cstad_tblMap : EntityTypeConfiguration<en_cstad_tbl>
    {
        public en_cstad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_cust_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_cust_key)
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

            this.Property(t => t.en_cstad_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            // Table & Column Mappings
            this.ToTable("en_cstad_tbl");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_cstad_crtdt).HasColumnName("en_cstad_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cstad_cmnts).HasColumnName("en_cstad_cmnts");
            this.Property(t => t.en_cstad_chgdt).HasColumnName("en_cstad_chgdt");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
        }
    }
}
