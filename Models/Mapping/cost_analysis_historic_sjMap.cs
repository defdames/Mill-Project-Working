using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cost_analysis_historic_sjMap : EntityTypeConfiguration<cost_analysis_historic_sj>
    {
        public cost_analysis_historic_sjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.im_pack_key, t.cost_year, t.uom_key });

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

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.item)
                .HasMaxLength(20);

            this.Property(t => t.packkey)
                .HasMaxLength(6);

            this.Property(t => t.company)
                .HasMaxLength(500);

            this.Property(t => t.manufacturingloc)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("cost_analysis_historic_sj");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.cost_year).HasColumnName("cost_year");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.in_whitm_bmscst).HasColumnName("in_whitm_bmscst");
            this.Property(t => t.in_whitm_pmscst).HasColumnName("in_whitm_pmscst");
            this.Property(t => t.in_whitm_bmoscst).HasColumnName("in_whitm_bmoscst");
            this.Property(t => t.in_whitm_pmoscst).HasColumnName("in_whitm_pmoscst");
            this.Property(t => t.in_whitm_brscst).HasColumnName("in_whitm_brscst");
            this.Property(t => t.in_whitm_prscst).HasColumnName("in_whitm_prscst");
            this.Property(t => t.in_whitm_broscst).HasColumnName("in_whitm_broscst");
            this.Property(t => t.in_whitm_proscst).HasColumnName("in_whitm_proscst");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.packkey).HasColumnName("packkey");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.manufacturingloc).HasColumnName("manufacturingloc");
            this.Property(t => t.yearsold).HasColumnName("yearsold");
            this.Property(t => t.poundssoldlc).HasColumnName("poundssoldlc");
            this.Property(t => t.dollarssoldlc).HasColumnName("dollarssoldlc");
            this.Property(t => t.avgpricelb).HasColumnName("avgpricelb");
        }
    }
}
