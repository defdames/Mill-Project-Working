using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class fy_sfasycmp_tblMap : EntityTypeConfiguration<fy_sfasycmp_tbl>
    {
        public fy_sfasycmp_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.fy_sfasycmp_pk);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.bm_asy_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.bm_cmp_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.bm_cmp_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.fy_sfasycmp_pk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("fy_sfasycmp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.bm_cmp_key).HasColumnName("bm_cmp_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.bm_cmp_flag).HasColumnName("bm_cmp_flag");
            this.Property(t => t.bm_cmp_effdt).HasColumnName("bm_cmp_effdt");
            this.Property(t => t.bm_cmp_inadt).HasColumnName("bm_cmp_inadt");
            this.Property(t => t.bm_cmp_yldqpa).HasColumnName("bm_cmp_yldqpa");
            this.Property(t => t.bm_cmp_uom).HasColumnName("bm_cmp_uom");
            this.Property(t => t.fy_sfasycmp_yld).HasColumnName("fy_sfasycmp_yld");
            this.Property(t => t.fy_sfasycmp_pk).HasColumnName("fy_sfasycmp_pk");
        }
    }
}
