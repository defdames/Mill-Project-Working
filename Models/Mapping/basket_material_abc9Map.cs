using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basket_material_abc9Map : EntityTypeConfiguration<basket_material_abc9>
    {
        public basket_material_abc9Map()
        {
            // Primary Key
            this.HasKey(t => t.in_item_key);

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("basket_material_abc9");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
        }
    }
}
