using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_shop_extMap : EntityTypeConfiguration<pm_shop_ext>
    {
        public pm_shop_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pm_shop_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.aa_initial_key)
                .HasMaxLength(3);

            this.Property(t => t.ai_mix_key)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("pm_shop_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.aa_initial_key).HasColumnName("aa_initial_key");
            this.Property(t => t.ai_mix_key).HasColumnName("ai_mix_key");
            this.Property(t => t.aj_imixhrs_key).HasColumnName("aj_imixhrs_key");
            this.Property(t => t.ak_fmixhrs_key).HasColumnName("ak_fmixhrs_key");
            this.Property(t => t.al_tmixhrs_key).HasColumnName("al_tmixhrs_key");
            this.Property(t => t.am_cycletm_key).HasColumnName("am_cycletm_key");
            this.Property(t => t.an_pckablty_key).HasColumnName("an_pckablty_key");
            this.Property(t => t.ao_filllevel_key).HasColumnName("ao_filllevel_key");
            this.Property(t => t.m_testing_ws).HasColumnName("m_testing_ws");
            this.Property(t => t.m_wash_ws).HasColumnName("m_wash_ws");
            this.Property(t => t.pm_shop_upcnt).HasColumnName("pm_shop_upcnt");
        }
    }
}
