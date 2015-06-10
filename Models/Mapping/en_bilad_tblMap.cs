using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_bilad_tblMap : EntityTypeConfiguration<en_bilad_tbl>
    {
        public en_bilad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_bill_key, t.im_adrtp_key, t.im_adres_key });

            // Properties
            this.Property(t => t.en_bill_key)
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

            this.Property(t => t.en_bilad_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            // Table & Column Mappings
            this.ToTable("en_bilad_tbl");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.en_bilad_crtdt).HasColumnName("en_bilad_crtdt");
            this.Property(t => t.en_bilad_chgdt).HasColumnName("en_bilad_chgdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_bilad_cmnts).HasColumnName("en_bilad_cmnts");
            this.Property(t => t.im_adrtp_upcnt).HasColumnName("im_adrtp_upcnt");
        }
    }
}
