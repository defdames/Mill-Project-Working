using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_advrepk_tblMap : EntityTypeConfiguration<pm_advrepk_tbl>
    {
        public pm_advrepk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.pm_advrepk_spack, t.pm_advrepk_tpack });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_advrepk_spack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pm_advrepk_tpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.pm_advrepk_astplid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pm_advrepk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pm_advrepk_spack).HasColumnName("pm_advrepk_spack");
            this.Property(t => t.pm_advrepk_tpack).HasColumnName("pm_advrepk_tpack");
            this.Property(t => t.pm_advrepk_advschf).HasColumnName("pm_advrepk_advschf");
            this.Property(t => t.pm_advrepk_pstpver).HasColumnName("pm_advrepk_pstpver");
            this.Property(t => t.pm_advrepk_crtdt).HasColumnName("pm_advrepk_crtdt");
            this.Property(t => t.pm_advrepk_chgdt).HasColumnName("pm_advrepk_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pm_advrepk_astplid).HasColumnName("pm_advrepk_astplid");
            this.Property(t => t.pm_advrepk_upcnt).HasColumnName("pm_advrepk_upcnt");
        }
    }
}
