using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class company_viewMap : EntityTypeConfiguration<company_view>
    {
        public company_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_cmp_desc });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("company_view");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_cmp_desc).HasColumnName("gl_cmp_desc");
        }
    }
}
