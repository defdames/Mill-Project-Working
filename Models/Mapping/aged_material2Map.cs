using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class aged_material2Map : EntityTypeConfiguration<aged_material2>
    {
        public aged_material2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.in_lot_key });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("aged_material2");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.trandate).HasColumnName("trandate");
        }
    }
}
