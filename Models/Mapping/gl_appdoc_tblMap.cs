using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_appdoc_tblMap : EntityTypeConfiguration<gl_appdoc_tbl>
    {
        public gl_appdoc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_appcd_key, t.gl_appdoc_key });

            // Properties
            this.Property(t => t.gl_appcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_appdoc_key)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_appdoc_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("gl_appdoc_tbl");
            this.Property(t => t.gl_appcd_key).HasColumnName("gl_appcd_key");
            this.Property(t => t.gl_appdoc_key).HasColumnName("gl_appdoc_key");
            this.Property(t => t.gl_appdoc_desc).HasColumnName("gl_appdoc_desc");
            this.Property(t => t.gl_journaltype_id).HasColumnName("gl_journaltype_id");
        }
    }
}
