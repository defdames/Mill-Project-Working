using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_igdout_extMap : EntityTypeConfiguration<pm_igdout_ext>
    {
        public pm_igdout_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.sf_ingrd_key, t.sf_opseq_key });

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

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.aa_initials_key)
                .HasMaxLength(3);

            this.Property(t => t.ab_system_key)
                .HasMaxLength(10);

            this.Property(t => t.ad_press_key)
                .HasMaxLength(3);

            this.Property(t => t.ag_compressor_key)
                .HasMaxLength(5);

            this.Property(t => t.ah_air_key)
                .HasMaxLength(5);

            this.Property(t => t.ao_pressure_key)
                .HasMaxLength(30);

            this.Property(t => t.ap_pressure_key)
                .HasMaxLength(30);

            this.Property(t => t.aq_pressure_key)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pm_igdout_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.aa_initials_key).HasColumnName("aa_initials_key");
            this.Property(t => t.an_dumps_key).HasColumnName("an_dumps_key");
            this.Property(t => t.ab_system_key).HasColumnName("ab_system_key");
            this.Property(t => t.ad_press_key).HasColumnName("ad_press_key");
            this.Property(t => t.ag_compressor_key).HasColumnName("ag_compressor_key");
            this.Property(t => t.ah_air_key).HasColumnName("ah_air_key");
            this.Property(t => t.ao_pressure_key).HasColumnName("ao_pressure_key");
            this.Property(t => t.ap_pressure_key).HasColumnName("ap_pressure_key");
            this.Property(t => t.aq_pressure_key).HasColumnName("aq_pressure_key");
            this.Property(t => t.ae_grindhrs_key).HasColumnName("ae_grindhrs_key");
            this.Property(t => t.af_millhrs_key).HasColumnName("af_millhrs_key");
            this.Property(t => t.ac_mills_key).HasColumnName("ac_mills_key");
            this.Property(t => t.ar_recvarwash_key).HasColumnName("ar_recvarwash_key");
            this.Property(t => t.pm_igdout_upcnt).HasColumnName("pm_igdout_upcnt");
        }
    }
}
