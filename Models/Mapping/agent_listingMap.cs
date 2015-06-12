using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agent_listingMap : EntityTypeConfiguration<agent_listing>
    {
        public agent_listingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_salsm_key, t.so_salsm_name, t.gl_cmp_key });

            // Properties
            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("agent_listing");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
