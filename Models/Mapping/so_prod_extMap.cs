using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_prod_extMap : EntityTypeConfiguration<so_prod_ext>
    {
        public so_prod_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_prod_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.xref_product_name)
                .HasMaxLength(30);

            this.Property(t => t.add_prod_name_ref_hist)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("so_prod_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.xref_product_name).HasColumnName("xref_product_name");
            this.Property(t => t.add_prod_name_ref_hist).HasColumnName("add_prod_name_ref_hist");
            this.Property(t => t.so_prod_upcnt).HasColumnName("so_prod_upcnt");
        }
    }
}
