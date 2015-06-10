using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bm_encmp_tblMap : EntityTypeConfiguration<bm_encmp_tbl>
    {
        public bm_encmp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bm_asy_key, t.bm_cmp_key, t.im_pack_key, t.bm_cmp_effdt, t.bm_cmp_flag });

            // Properties
            this.Property(t => t.bm_asy_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.bm_cmp_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.bm_cmp_flag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bm_cmp_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bm_cmp_wuom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("bm_encmp_tbl");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.bm_cmp_key).HasColumnName("bm_cmp_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.bm_cmp_effdt).HasColumnName("bm_cmp_effdt");
            this.Property(t => t.bm_cmp_flag).HasColumnName("bm_cmp_flag");
            this.Property(t => t.bm_cmp_inadt).HasColumnName("bm_cmp_inadt");
            this.Property(t => t.bm_cmp_yld).HasColumnName("bm_cmp_yld");
            this.Property(t => t.bm_cmp_qpa).HasColumnName("bm_cmp_qpa");
            this.Property(t => t.bm_cmp_uom).HasColumnName("bm_cmp_uom");
            this.Property(t => t.bm_cmp_wgt).HasColumnName("bm_cmp_wgt");
            this.Property(t => t.bm_cmp_exwgt).HasColumnName("bm_cmp_exwgt");
            this.Property(t => t.bm_cmp_wuom).HasColumnName("bm_cmp_wuom");
        }
    }
}
