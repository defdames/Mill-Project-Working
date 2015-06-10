using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_sbr_product_xrefMap : EntityTypeConfiguration<mis_cube_sales_sbr_product_xref>
    {
        public mis_cube_sales_sbr_product_xrefMap()
        {
            // Primary Key
            this.HasKey(t => t.sbr_en_prod_key);

            // Properties
            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sbr_en_prod_key)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_sbr_product_xref");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.sbr_en_prod_key).HasColumnName("sbr_en_prod_key");
        }
    }
}
