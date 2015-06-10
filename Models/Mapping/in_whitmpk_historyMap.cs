using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whitmpk_historyMap : EntityTypeConfiguration<in_whitmpk_history>
    {
        public in_whitmpk_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.im_pack_key, t.cost_year });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.cost_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_comcd_key)
                .HasMaxLength(50);

            this.Property(t => t.in_whitmpk_srcwhs)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("in_whitmpk_history");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.cost_year).HasColumnName("cost_year");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.in_whitmpk_bmscst).HasColumnName("in_whitmpk_bmscst");
            this.Property(t => t.in_whitmpk_pmscst).HasColumnName("in_whitmpk_pmscst");
            this.Property(t => t.in_whitmpk_bmoscst).HasColumnName("in_whitmpk_bmoscst");
            this.Property(t => t.in_whitmpk_pmoscst).HasColumnName("in_whitmpk_pmoscst");
            this.Property(t => t.in_whitmpk_brscst).HasColumnName("in_whitmpk_brscst");
            this.Property(t => t.in_whitmpk_prscst).HasColumnName("in_whitmpk_prscst");
            this.Property(t => t.in_whitmpk_broscst).HasColumnName("in_whitmpk_broscst");
            this.Property(t => t.in_whitmpk_proscst).HasColumnName("in_whitmpk_proscst");
            this.Property(t => t.in_whitmpk_cdscst).HasColumnName("in_whitmpk_cdscst");
            this.Property(t => t.in_whitmpk_frtscst).HasColumnName("in_whitmpk_frtscst");
            this.Property(t => t.in_whitmpk_mktscst).HasColumnName("in_whitmpk_mktscst");
            this.Property(t => t.in_whitmpk_othscst).HasColumnName("in_whitmpk_othscst");
            this.Property(t => t.in_whitmpk_bmpcst).HasColumnName("in_whitmpk_bmpcst");
            this.Property(t => t.in_whitmpk_pmpcst).HasColumnName("in_whitmpk_pmpcst");
            this.Property(t => t.in_whitmpk_bmopcst).HasColumnName("in_whitmpk_bmopcst");
            this.Property(t => t.in_whitmpk_pmopcst).HasColumnName("in_whitmpk_pmopcst");
            this.Property(t => t.in_whitmpk_brpcst).HasColumnName("in_whitmpk_brpcst");
            this.Property(t => t.in_whitmpk_prpcst).HasColumnName("in_whitmpk_prpcst");
            this.Property(t => t.in_whitmpk_bropcst).HasColumnName("in_whitmpk_bropcst");
            this.Property(t => t.in_whitmpk_propcst).HasColumnName("in_whitmpk_propcst");
            this.Property(t => t.in_whitmpk_cdpcst).HasColumnName("in_whitmpk_cdpcst");
            this.Property(t => t.in_whitmpk_frtpcst).HasColumnName("in_whitmpk_frtpcst");
            this.Property(t => t.in_whitmpk_mktpcst).HasColumnName("in_whitmpk_mktpcst");
            this.Property(t => t.in_whitmpk_othpcst).HasColumnName("in_whitmpk_othpcst");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.in_whitmpk_srcwhs).HasColumnName("in_whitmpk_srcwhs");
        }
    }
}
