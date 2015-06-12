using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class archway_open_order_dumpMap : EntityTypeConfiguration<archway_open_order_dump>
    {
        public archway_open_order_dumpMap()
        {
            // Primary Key
            this.HasKey(t => new { t.orderno, t.ponumber, t.product, t.packqty, t.promisedate });

            // Properties
            this.Property(t => t.orderno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ponumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.uom)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("archway_open_order_dump");
            this.Property(t => t.orderno).HasColumnName("orderno");
            this.Property(t => t.ponumber).HasColumnName("ponumber");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.packqty).HasColumnName("packqty");
            this.Property(t => t.weightqty).HasColumnName("weightqty");
            this.Property(t => t.uom).HasColumnName("uom");
            this.Property(t => t.extprice).HasColumnName("extprice");
            this.Property(t => t.promisedate).HasColumnName("promisedate");
        }
    }
}
