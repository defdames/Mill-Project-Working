using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class active_routings_using_costingMap : EntityTypeConfiguration<active_routings_using_costing>
    {
        public active_routings_using_costingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rout_key, t.sf_rthdr_runtm, t.sf_rthdr_runsz, t.sf_rthdr_runuom });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rsrce_key)
                .HasMaxLength(10);

            this.Property(t => t.sf_rthdr_runuom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("active_routings_using_costing");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_rthdr_runtm).HasColumnName("sf_rthdr_runtm");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.sf_rtstp_stdtm).HasColumnName("sf_rtstp_stdtm");
            this.Property(t => t.sf_rthdr_runsz).HasColumnName("sf_rthdr_runsz");
            this.Property(t => t.sf_rthdr_runuom).HasColumnName("sf_rthdr_runuom");
            this.Property(t => t.sf_rsrce_sdirc).HasColumnName("sf_rsrce_sdirc");
            this.Property(t => t.sf_rsrce_sovhf).HasColumnName("sf_rsrce_sovhf");
            this.Property(t => t.sf_rout_uldt_old).HasColumnName("sf_rout_uldt_old");
            this.Property(t => t.sf_rout_uldt).HasColumnName("sf_rout_uldt");
            this.Property(t => t.sf_rout_bldt).HasColumnName("sf_rout_bldt");
            this.Property(t => t.uldt2).HasColumnName("uldt2");
        }
    }
}
