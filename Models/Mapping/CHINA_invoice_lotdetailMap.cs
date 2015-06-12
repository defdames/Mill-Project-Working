using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_invoice_lotdetailMap : EntityTypeConfiguration<CHINA_invoice_lotdetail>
    {
        public CHINA_invoice_lotdetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.SODTL, t.countryoforigin });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.INVNO)
                .HasMaxLength(10);

            this.Property(t => t.SODTL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.countryoforigin)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("CHINA_invoice_lotdetail");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.INVNO).HasColumnName("INVNO");
            this.Property(t => t.SODTL).HasColumnName("SODTL");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.ShpQty).HasColumnName("ShpQty");
            this.Property(t => t.countryoforigin).HasColumnName("countryoforigin");
        }
    }
}
