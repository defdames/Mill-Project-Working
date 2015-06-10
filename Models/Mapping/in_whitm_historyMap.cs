using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whitm_historyMap : EntityTypeConfiguration<in_whitm_history>
    {
        public in_whitm_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.cost_year });

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

            this.Property(t => t.cost_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.UOM_Key)
                .HasMaxLength(5);

            this.Property(t => t.in_comcd_key)
                .HasMaxLength(50);

            this.Property(t => t.in_whitm_srcwhs)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("in_whitm_history");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.cost_year).HasColumnName("cost_year");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.UOM_Key).HasColumnName("UOM_Key");
            this.Property(t => t.in_whitm_bmscst).HasColumnName("in_whitm_bmscst");
            this.Property(t => t.in_whitm_pmscst).HasColumnName("in_whitm_pmscst");
            this.Property(t => t.in_whitm_bmoscst).HasColumnName("in_whitm_bmoscst");
            this.Property(t => t.in_whitm_pmoscst).HasColumnName("in_whitm_pmoscst");
            this.Property(t => t.in_whitm_brscst).HasColumnName("in_whitm_brscst");
            this.Property(t => t.in_whitm_prscst).HasColumnName("in_whitm_prscst");
            this.Property(t => t.in_whitm_broscst).HasColumnName("in_whitm_broscst");
            this.Property(t => t.in_whitm_proscst).HasColumnName("in_whitm_proscst");
            this.Property(t => t.in_whitm_cdscst).HasColumnName("in_whitm_cdscst");
            this.Property(t => t.in_whitm_frtscst).HasColumnName("in_whitm_frtscst");
            this.Property(t => t.in_whitm_mktscst).HasColumnName("in_whitm_mktscst");
            this.Property(t => t.in_whitm_othscst).HasColumnName("in_whitm_othscst");
            this.Property(t => t.in_whitm_bmpcst).HasColumnName("in_whitm_bmpcst");
            this.Property(t => t.in_whitm_pmpcst).HasColumnName("in_whitm_pmpcst");
            this.Property(t => t.in_whitm_bmopcst).HasColumnName("in_whitm_bmopcst");
            this.Property(t => t.in_whitm_pmopcst).HasColumnName("in_whitm_pmopcst");
            this.Property(t => t.in_whitm_brpcst).HasColumnName("in_whitm_brpcst");
            this.Property(t => t.in_whitm_prpcst).HasColumnName("in_whitm_prpcst");
            this.Property(t => t.in_whitm_bropcst).HasColumnName("in_whitm_bropcst");
            this.Property(t => t.in_whitm_propcst).HasColumnName("in_whitm_propcst");
            this.Property(t => t.in_whitm_cdpcst).HasColumnName("in_whitm_cdpcst");
            this.Property(t => t.in_whitm_frtpcst).HasColumnName("in_whitm_frtpcst");
            this.Property(t => t.in_whitm_mktpcst).HasColumnName("in_whitm_mktpcst");
            this.Property(t => t.in_whitm_othpcst).HasColumnName("in_whitm_othpcst");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.in_whitm_srcwhs).HasColumnName("in_whitm_srcwhs");
        }
    }
}
