using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_gl_appdoc_tblMap : EntityTypeConfiguration<lang_gl_appdoc_tbl>
    {
        public lang_gl_appdoc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_appcd_key, t.gl_appdoc_key, t.language });

            // Properties
            this.Property(t => t.gl_appcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_appdoc_key)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_appdoc_desc)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_gl_appdoc_tbl");
            this.Property(t => t.gl_appcd_key).HasColumnName("gl_appcd_key");
            this.Property(t => t.gl_appdoc_key).HasColumnName("gl_appdoc_key");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.gl_appdoc_desc).HasColumnName("gl_appdoc_desc");
        }
    }
}
