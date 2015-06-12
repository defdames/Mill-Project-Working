using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_purchase_ordersMap : EntityTypeConfiguration<advpl_purchase_orders>
    {
        public advpl_purchase_ordersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Code, t.reqDate, t.prmdate, t.company });

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(34);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("advpl_purchase_orders");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.reqDate).HasColumnName("reqDate");
            this.Property(t => t.prmdate).HasColumnName("prmdate");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
