using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_2011_smc_forecastMap : EntityTypeConfiguration<tmp_2011_smc_forecast>
    {
        public tmp_2011_smc_forecastMap()
        {
            // Primary Key
            this.HasKey(t => t.DateSold);

            // Properties
            this.Property(t => t.DateSold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.region)
                .HasMaxLength(255);

            this.Property(t => t.product)
                .HasMaxLength(255);

            this.Property(t => t.salestype)
                .HasMaxLength(255);

            this.Property(t => t.item)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tmp_2011_smc_forecast");
            this.Property(t => t.DateSold).HasColumnName("DateSold");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.salestype).HasColumnName("salestype");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.item).HasColumnName("item");
        }
    }
}
