using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_invoice_custins_childMap : EntityTypeConfiguration<CHINA_invoice_custins_child>
    {
        public CHINA_invoice_custins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.b)
                .HasMaxLength(10);

            this.Property(t => t.text_value)
                .HasMaxLength(1786);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.d)
                .HasMaxLength(10);

            this.Property(t => t.e)
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_invoice_custins_child");
            this.Property(t => t.a).HasColumnName("a");
            this.Property(t => t.b).HasColumnName("b");
            this.Property(t => t.text_value).HasColumnName("text_value");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.d).HasColumnName("d");
            this.Property(t => t.e).HasColumnName("e");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
