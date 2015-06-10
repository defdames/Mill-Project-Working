using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class base_price_keyMap : EntityTypeConfiguration<base_price_key>
    {
        public base_price_keyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pc_bsprhd_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.pc_bsprhd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("base_price_key");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
