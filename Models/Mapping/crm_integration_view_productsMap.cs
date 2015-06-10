using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class crm_integration_view_productsMap : EntityTypeConfiguration<crm_integration_view_products>
    {
        public crm_integration_view_productsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PackKey, t.Avg_Cost });

            // Properties
            this.Property(t => t.Product_Key)
                .HasMaxLength(20);

            this.Property(t => t.Product_Desc)
                .HasMaxLength(60);

            this.Property(t => t.Item_Key)
                .HasMaxLength(20);

            this.Property(t => t.PackKey)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("crm_integration_view_products");
            this.Property(t => t.Product_Key).HasColumnName("Product Key");
            this.Property(t => t.Product_Desc).HasColumnName("Product Desc");
            this.Property(t => t.Item_Key).HasColumnName("Item Key");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.Avg_Cost).HasColumnName("Avg Cost");
        }
    }
}
