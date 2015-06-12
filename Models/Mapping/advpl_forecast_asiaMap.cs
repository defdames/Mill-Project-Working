using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_forecast_asiaMap : EntityTypeConfiguration<advpl_forecast_asia>
    {
        public advpl_forecast_asiaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.product_code, t.company, t.class_01 });

            // Properties
            this.Property(t => t.product_code)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.warehouse_code)
                .HasMaxLength(50);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.class_01)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("advpl_forecast_asia");
            this.Property(t => t.product_code).HasColumnName("product_code");
            this.Property(t => t.warehouse_code).HasColumnName("warehouse_code");
            this.Property(t => t.adjQuantity).HasColumnName("adjQuantity");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.class_01).HasColumnName("class_01");
        }
    }
}
