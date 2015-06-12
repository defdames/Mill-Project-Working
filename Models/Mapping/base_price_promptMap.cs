using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class base_price_promptMap : EntityTypeConfiguration<base_price_prompt>
    {
        public base_price_promptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_bsprhd_key, t.en_prod_key, t.gl_cmp_desc, t.pc_bsprhd_desc, t.en_prod_desc });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_bsprhd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pc_bsprhd_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("base_price_prompt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.gl_cmp_desc).HasColumnName("gl_cmp_desc");
            this.Property(t => t.pc_bsprhd_desc).HasColumnName("pc_bsprhd_desc");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
        }
    }
}
