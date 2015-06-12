using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_europe_regionsMap : EntityTypeConfiguration<mis_cube_sales_europe_regions>
    {
        public mis_cube_sales_europe_regionsMap()
        {
            // Primary Key
            this.HasKey(t => t.region);

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.country)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_europe_regions");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.country).HasColumnName("country");
        }
    }
}
