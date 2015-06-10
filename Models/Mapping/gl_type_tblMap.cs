using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_type_tblMap : EntityTypeConfiguration<gl_type_tbl>
    {
        public gl_type_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_type_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_type_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_type_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_type_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_type_key).HasColumnName("gl_type_key");
            this.Property(t => t.gl_type_desc).HasColumnName("gl_type_desc");
            this.Property(t => t.gl_type_upcnt).HasColumnName("gl_type_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_type_chgdt).HasColumnName("gl_type_chgdt");
            this.Property(t => t.gl_type_crtdt).HasColumnName("gl_type_crtdt");
        }
    }
}
