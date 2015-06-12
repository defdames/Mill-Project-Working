using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_GL_Chart_AccountsMap : EntityTypeConfiguration<CHINA_GL_Chart_Accounts>
    {
        public CHINA_GL_Chart_AccountsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AcctNum, t.AcctDesc, t.Classkey, t.Type, t.Dcind, t.gl_class_key2, t.gl_cmp_key });

            // Properties
            this.Property(t => t.AcctNum)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.AcctDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Classkey)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Dcind)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_class_desc)
                .HasMaxLength(30);

            this.Property(t => t.gl_type_desc)
                .HasMaxLength(30);

            this.Property(t => t.gl_class_key2)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_GL_Chart_Accounts");
            this.Property(t => t.AcctNum).HasColumnName("AcctNum");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.Classkey).HasColumnName("Classkey");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Dcind).HasColumnName("Dcind");
            this.Property(t => t.gl_class_desc).HasColumnName("gl_class_desc");
            this.Property(t => t.gl_type_desc).HasColumnName("gl_type_desc");
            this.Property(t => t.gl_class_key2).HasColumnName("gl_class_key2");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
