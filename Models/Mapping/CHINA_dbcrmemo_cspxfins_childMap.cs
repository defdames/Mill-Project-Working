using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_dbcrmemo_cspxfins_childMap : EntityTypeConfiguration<CHINA_dbcrmemo_cspxfins_child>
    {
        public CHINA_dbcrmemo_cspxfins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.text_value, t.ar_dbcrm_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.b)
                .HasMaxLength(10);

            this.Property(t => t.text_value)
                .IsRequired()
                .HasMaxLength(1786);

            this.Property(t => t.c)
                .HasMaxLength(10);

            this.Property(t => t.d)
                .HasMaxLength(20);

            this.Property(t => t.e)
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_dbcrmemo_cspxfins_child");
            this.Property(t => t.a).HasColumnName("a");
            this.Property(t => t.b).HasColumnName("b");
            this.Property(t => t.text_value).HasColumnName("text_value");
            this.Property(t => t.c).HasColumnName("c");
            this.Property(t => t.d).HasColumnName("d");
            this.Property(t => t.e).HasColumnName("e");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
