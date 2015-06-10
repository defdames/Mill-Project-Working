using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_cmp_tblMap : EntityTypeConfiguration<web_sa_cmp_tbl>
    {
        public web_sa_cmp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_user_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.default)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("web_sa_cmp_tbl");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.default).HasColumnName("default");
        }
    }
}
