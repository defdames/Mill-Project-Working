using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_xrefMap : EntityTypeConfiguration<CHINA_xref>
    {
        public CHINA_xrefMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_interface_srce, t.gl_interface_docty, t.English_Desc, t.Chinese_Desc, t.gl_cmp_key, t.gl_interface_date, t.gl_interface_crtdt });

            // Properties
            this.Property(t => t.Subpost__)
                .HasMaxLength(30);

            this.Property(t => t.Document__)
                .HasMaxLength(10);

            this.Property(t => t.gl_interface_srce)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_interface_docty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.English_Desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Chinese_Desc)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.entry_no_new)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CHINA_xref");
            this.Property(t => t.Subpost__).HasColumnName("Subpost #");
            this.Property(t => t.Document__).HasColumnName("Document #");
            this.Property(t => t.gl_interface_srce).HasColumnName("gl_interface_srce");
            this.Property(t => t.gl_interface_docty).HasColumnName("gl_interface_docty");
            this.Property(t => t.English_Desc).HasColumnName("English Desc");
            this.Property(t => t.Chinese_Desc).HasColumnName("Chinese Desc");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.entry_no_new).HasColumnName("entry_no_new");
            this.Property(t => t.gl_interface_date).HasColumnName("gl_interface_date");
            this.Property(t => t.gl_interface_crtdt).HasColumnName("gl_interface_crtdt");
        }
    }
}
