using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_INTERNATIONAL_INVOICE3Map : EntityTypeConfiguration<CHINA_INTERNATIONAL_INVOICE3>
    {
        public CHINA_INTERNATIONAL_INVOICE3Map()
        {
            // Primary Key
            this.HasKey(t => new { t.in_alloc_line, t.in_alloc_ordid, t.gl_cmp_key, t.im_adres_cntry });

            // Properties
            this.Property(t => t.in_alloc_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_alloc_ordid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_adres_cntry)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("CHINA_INTERNATIONAL_INVOICE3");
            this.Property(t => t.in_alloc_line).HasColumnName("in_alloc_line");
            this.Property(t => t.in_alloc_ordid).HasColumnName("in_alloc_ordid");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
        }
    }
}
