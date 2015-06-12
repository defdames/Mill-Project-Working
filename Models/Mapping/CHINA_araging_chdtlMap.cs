using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_araging_chdtlMap : EntityTypeConfiguration<CHINA_araging_chdtl>
    {
        public CHINA_araging_chdtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_chdtl_dockey, t.ar_chdtl_doctype, t.ar_bill_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ar_chdtl_dockey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_chdtl_doctype)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_araging_chdtl");
            this.Property(t => t.ar_chdtl_dockey).HasColumnName("ar_chdtl_dockey");
            this.Property(t => t.ar_chdtl_doctype).HasColumnName("ar_chdtl_doctype");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_chdtl_appamt).HasColumnName("ar_chdtl_appamt");
            this.Property(t => t.ar_chdtl_appamtf).HasColumnName("ar_chdtl_appamtf");
        }
    }
}
