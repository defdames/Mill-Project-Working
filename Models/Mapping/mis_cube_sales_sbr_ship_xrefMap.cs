using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_sbr_ship_xrefMap : EntityTypeConfiguration<mis_cube_sales_sbr_ship_xref>
    {
        public mis_cube_sales_sbr_ship_xrefMap()
        {
            // Primary Key
            this.HasKey(t => t.sbr_en_ship_key);

            // Properties
            this.Property(t => t.sbr_en_ship_key)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_sbr_ship_xref");
            this.Property(t => t.sbr_en_ship_key).HasColumnName("sbr_en_ship_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
        }
    }
}
