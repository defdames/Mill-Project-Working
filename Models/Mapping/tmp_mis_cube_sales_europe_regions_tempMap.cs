using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_mis_cube_sales_europe_regions_tempMap : EntityTypeConfiguration<tmp_mis_cube_sales_europe_regions_temp>
    {
        public tmp_mis_cube_sales_europe_regions_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.region, t.company });

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.top_customer_name)
                .HasMaxLength(20);

            this.Property(t => t.owner)
                .HasMaxLength(255);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("tmp_mis_cube_sales_europe_regions_temp");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
