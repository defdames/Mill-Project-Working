using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_buyc_tblMap : EntityTypeConfiguration<en_buyc_tbl>
    {
        public en_buyc_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_buyc_key);

            // Properties
            this.Property(t => t.en_buyc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_buyc_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_buyc_tbl");
            this.Property(t => t.en_buyc_key).HasColumnName("en_buyc_key");
            this.Property(t => t.en_buyc_desc).HasColumnName("en_buyc_desc");
            this.Property(t => t.en_buyc_upcnt).HasColumnName("en_buyc_upcnt");
            this.Property(t => t.en_buyc_crtdt).HasColumnName("en_buyc_crtdt");
            this.Property(t => t.en_buyc_chgdt).HasColumnName("en_buyc_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
