using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_inventory_by_lot2Map : EntityTypeConfiguration<CHINA_inventory_by_lot2>
    {
        public CHINA_inventory_by_lot2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_ivhdr_key, t.gl_crcnv_rate, t.gl_crncy_from });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_from)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("CHINA_inventory_by_lot2");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.gl_crcnv_rate).HasColumnName("gl_crcnv_rate");
            this.Property(t => t.gl_crncy_from).HasColumnName("gl_crncy_from");
        }
    }
}
