using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_base_priceMap : EntityTypeConfiguration<CHINA_base_price>
    {
        public CHINA_base_priceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_bsprhd_key, t.pc_bsprdt_ppcind, t.pc_bsprdt_prod, t.im_pack_key, t.pc_bsprdt_price, t.pc_bsprdt_uom, t.pc_bsprhd_exdesc });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_bsprhd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_bsprdt_ppcind)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_bsprdt_prod)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pc_bsprdt_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .HasMaxLength(60);

            this.Property(t => t.pc_bsprhd_exdesc)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CHINA_base_price");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.pc_bsprdt_ppcind).HasColumnName("pc_bsprdt_ppcind");
            this.Property(t => t.pc_bsprdt_prod).HasColumnName("pc_bsprdt_prod");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pc_bsprdt_ordefdt).HasColumnName("pc_bsprdt_ordefdt");
            this.Property(t => t.pc_bsprdt_ordiadt).HasColumnName("pc_bsprdt_ordiadt");
            this.Property(t => t.pc_bsprdt_price).HasColumnName("pc_bsprdt_price");
            this.Property(t => t.pc_bsprdt_uom).HasColumnName("pc_bsprdt_uom");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.pc_bsprhd_exdesc).HasColumnName("pc_bsprhd_exdesc");
        }
    }
}
