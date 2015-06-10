using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_fob_tblMap : EntityTypeConfiguration<en_fob_tbl>
    {
        public en_fob_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_fob_key);

            // Properties
            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_fob_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_fob_tbl");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.en_fob_desc).HasColumnName("en_fob_desc");
            this.Property(t => t.en_fob_ownf).HasColumnName("en_fob_ownf");
            this.Property(t => t.en_fob_crtdt).HasColumnName("en_fob_crtdt");
            this.Property(t => t.en_fob_chgdt).HasColumnName("en_fob_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_fob_upcnt).HasColumnName("en_fob_upcnt");
        }
    }
}
