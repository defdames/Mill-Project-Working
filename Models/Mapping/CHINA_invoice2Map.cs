using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_invoice2Map : EntityTypeConfiguration<CHINA_invoice2>
    {
        public CHINA_invoice2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.e)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CHINA_invoice2");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.e).HasColumnName("e");
        }
    }
}
