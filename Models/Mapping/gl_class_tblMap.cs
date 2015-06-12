using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_class_tblMap : EntityTypeConfiguration<gl_class_tbl>
    {
        public gl_class_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_class_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_class_key)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_class_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_class_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_class_key).HasColumnName("gl_class_key");
            this.Property(t => t.gl_class_desc).HasColumnName("gl_class_desc");
            this.Property(t => t.gl_class_upcnt).HasColumnName("gl_class_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_class_chgdt).HasColumnName("gl_class_chgdt");
            this.Property(t => t.gl_class_crtdt).HasColumnName("gl_class_crtdt");
        }
    }
}
