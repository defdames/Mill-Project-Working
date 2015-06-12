using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_salsm_extMap : EntityTypeConfiguration<so_salsm_ext>
    {
        public so_salsm_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_salsm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.zone)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.xref_salsm_name)
                .HasMaxLength(20);

            this.Property(t => t.xref_vendor_remitto)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_salsm_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.zone).HasColumnName("zone");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.xref_salsm_name).HasColumnName("xref_salsm_name");
            this.Property(t => t.xref_vendor_remitto).HasColumnName("xref_vendor_remitto");
            this.Property(t => t.so_salsm_upcnt).HasColumnName("so_salsm_upcnt");
        }
    }
}
