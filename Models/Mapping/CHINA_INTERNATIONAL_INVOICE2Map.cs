using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_INTERNATIONAL_INVOICE2Map : EntityTypeConfiguration<CHINA_INTERNATIONAL_INVOICE2>
    {
        public CHINA_INTERNATIONAL_INVOICE2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.in_pklot_doc, t.in_pklot_line, t.gl_cmp_key, t.im_adres_cntry, t.in_item_key, t.in_lot_key });

            // Properties
            this.Property(t => t.in_pklot_doc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_pklot_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_adres_cntry)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("CHINA_INTERNATIONAL_INVOICE2");
            this.Property(t => t.in_pklot_doc).HasColumnName("in_pklot_doc");
            this.Property(t => t.in_pklot_line).HasColumnName("in_pklot_line");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
        }
    }
}
