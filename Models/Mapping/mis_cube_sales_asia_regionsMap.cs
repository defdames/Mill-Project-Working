using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_asia_regionsMap : EntityTypeConfiguration<mis_cube_sales_asia_regions>
    {
        public mis_cube_sales_asia_regionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.region, t.country });

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_asia_regions");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.country).HasColumnName("country");
        }
    }
}
