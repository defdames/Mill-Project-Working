using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_international_invoice_addonsMap : EntityTypeConfiguration<CHINA_international_invoice_addons>
    {
        public CHINA_international_invoice_addonsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.ExtPrice, t.gl_cmp_key, t.VATAMT, t.vatrate });

            // Properties
            this.Property(t => t.ProdKey)
                .HasMaxLength(20);

            this.Property(t => t.ProdDesc)
                .HasMaxLength(60);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_international_invoice_addons");
            this.Property(t => t.ProdKey).HasColumnName("ProdKey");
            this.Property(t => t.ProdDesc).HasColumnName("ProdDesc");
            this.Property(t => t.ShipType).HasColumnName("ShipType");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.ExtPrice).HasColumnName("ExtPrice");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.VATAMT).HasColumnName("VATAMT");
            this.Property(t => t.vatrate).HasColumnName("vatrate");
        }
    }
}
