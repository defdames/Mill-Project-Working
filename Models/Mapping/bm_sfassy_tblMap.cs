using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bm_sfassy_tblMap : EntityTypeConfiguration<bm_sfassy_tbl>
    {
        public bm_sfassy_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.bm_asy_key });

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

            this.Property(t => t.bm_asy_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.bm_asy_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bm_asy_vuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bm_asy_blkuom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("bm_sfassy_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.bm_asy_desc).HasColumnName("bm_asy_desc");
            this.Property(t => t.bm_asy_typ).HasColumnName("bm_asy_typ");
            this.Property(t => t.bm_asy_yld).HasColumnName("bm_asy_yld");
            this.Property(t => t.bm_asy_wgt).HasColumnName("bm_asy_wgt");
            this.Property(t => t.bm_asy_wuom).HasColumnName("bm_asy_wuom");
            this.Property(t => t.bm_asy_vol).HasColumnName("bm_asy_vol");
            this.Property(t => t.bm_asy_vuom).HasColumnName("bm_asy_vuom");
            this.Property(t => t.bm_asy_blkqty).HasColumnName("bm_asy_blkqty");
            this.Property(t => t.bm_asy_blkuom).HasColumnName("bm_asy_blkuom");
        }
    }
}
