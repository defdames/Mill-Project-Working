using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_packing_list_custins_childMap : EntityTypeConfiguration<CHINA_packing_list_custins_child>
    {
        public CHINA_packing_list_custins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.b)
                .HasMaxLength(10);

            this.Property(t => t.custins_text_value)
                .HasMaxLength(1786);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.d)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_packing_list_custins_child");
            this.Property(t => t.a).HasColumnName("a");
            this.Property(t => t.b).HasColumnName("b");
            this.Property(t => t.custins_text_value).HasColumnName("custins_text_value");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.d).HasColumnName("d");
            this.Property(t => t.e).HasColumnName("e");
            this.Property(t => t.f).HasColumnName("f");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
