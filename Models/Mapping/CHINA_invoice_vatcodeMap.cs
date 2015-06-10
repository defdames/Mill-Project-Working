using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_invoice_vatcodeMap : EntityTypeConfiguration<CHINA_invoice_vatcode>
    {
        public CHINA_invoice_vatcodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_ivhdr_key, t.gl_vatcd_key, t.gl_vatrate_pct });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_invoice_vatcode");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.VATAMT).HasColumnName("VATAMT");
        }
    }
}
