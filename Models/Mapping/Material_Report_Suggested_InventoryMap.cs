using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Material_Report_Suggested_InventoryMap : EntityTypeConfiguration<Material_Report_Suggested_Inventory>
    {
        public Material_Report_Suggested_InventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Commodity);

            // Properties
            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Material_Report_Suggested_Inventory");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.Suggested_Inv).HasColumnName("Suggested_Inv");
        }
    }
}
