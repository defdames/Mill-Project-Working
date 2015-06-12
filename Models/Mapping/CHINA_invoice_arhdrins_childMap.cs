using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_invoice_arhdrins_childMap : EntityTypeConfiguration<CHINA_invoice_arhdrins_child>
    {
        public CHINA_invoice_arhdrins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.im_incls_key)
                .HasMaxLength(10);

            this.Property(t => t.text_value)
                .HasMaxLength(1786);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_invoice_arhdrins_child");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.text_value).HasColumnName("text_value");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
