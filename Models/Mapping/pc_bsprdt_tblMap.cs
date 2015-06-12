using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_bsprdt_tblMap : EntityTypeConfiguration<pc_bsprdt_tbl>
    {
        public pc_bsprdt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_bsprhd_key, t.pc_bsprdt_ppcind, t.pc_bsprdt_prod, t.im_pack_key, t.pc_bsprdt_key });

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

            this.Property(t => t.pc_bsprdt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_bsprdt_uom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pc_bsprdt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.pc_bsprdt_ppcind).HasColumnName("pc_bsprdt_ppcind");
            this.Property(t => t.pc_bsprdt_prod).HasColumnName("pc_bsprdt_prod");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pc_bsprdt_key).HasColumnName("pc_bsprdt_key");
            this.Property(t => t.pc_bsprdt_price).HasColumnName("pc_bsprdt_price");
            this.Property(t => t.pc_bsprdt_uom).HasColumnName("pc_bsprdt_uom");
            this.Property(t => t.pc_bsprdt_ordefdt).HasColumnName("pc_bsprdt_ordefdt");
            this.Property(t => t.pc_bsprdt_ordiadt).HasColumnName("pc_bsprdt_ordiadt");
            this.Property(t => t.pc_bsprdt_shpefdt).HasColumnName("pc_bsprdt_shpefdt");
            this.Property(t => t.pc_bsprdt_shpiadt).HasColumnName("pc_bsprdt_shpiadt");
            this.Property(t => t.pc_bsprdt_ordefff).HasColumnName("pc_bsprdt_ordefff");
            this.Property(t => t.pc_bsprdt_shpefff).HasColumnName("pc_bsprdt_shpefff");
            this.Property(t => t.pc_bsprdt_inact).HasColumnName("pc_bsprdt_inact");
            this.Property(t => t.pc_bsprdt_reprchgf).HasColumnName("pc_bsprdt_reprchgf");
        }
    }
}
