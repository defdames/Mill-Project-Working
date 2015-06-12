using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_sales_ordersMap : EntityTypeConfiguration<advpl_sales_orders>
    {
        public advpl_sales_ordersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Code, t.Date, t.company });

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(34);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("advpl_sales_orders");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
