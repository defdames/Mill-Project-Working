using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_regionMap : EntityTypeConfiguration<pds_region>
    {
        public pds_regionMap()
        {
            // Primary Key
            this.HasKey(t => t.region);

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("pds_region");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
