using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_sched_tblMap : EntityTypeConfiguration<pn_sched_tbl>
    {
        public pn_sched_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.pn_sched_key);

            // Properties
            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_sched_entty)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_sched_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.pn_fcast_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_sched_ovly)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_sched_hldpd)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_sched_hldps)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_sched_relvl)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_sched_pnlvl)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pn_sched_tbl");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_type).HasColumnName("pn_sched_type");
            this.Property(t => t.pn_sched_entty).HasColumnName("pn_sched_entty");
            this.Property(t => t.pn_sched_desc).HasColumnName("pn_sched_desc");
            this.Property(t => t.pn_sched_tmfce).HasColumnName("pn_sched_tmfce");
            this.Property(t => t.pn_sched_horzn).HasColumnName("pn_sched_horzn");
            this.Property(t => t.pn_fcast_key).HasColumnName("pn_fcast_key");
            this.Property(t => t.pn_sched_ovly).HasColumnName("pn_sched_ovly");
            this.Property(t => t.pn_sched_rshin).HasColumnName("pn_sched_rshin");
            this.Property(t => t.pn_sched_rshot).HasColumnName("pn_sched_rshot");
            this.Property(t => t.pn_sched_ssdip).HasColumnName("pn_sched_ssdip");
            this.Property(t => t.pn_sched_hldpd).HasColumnName("pn_sched_hldpd");
            this.Property(t => t.pn_sched_hldps).HasColumnName("pn_sched_hldps");
            this.Property(t => t.pn_sched_lvlcd).HasColumnName("pn_sched_lvlcd");
            this.Property(t => t.pn_sched_relvl).HasColumnName("pn_sched_relvl");
            this.Property(t => t.pn_sched_rshif).HasColumnName("pn_sched_rshif");
            this.Property(t => t.pn_sched_rshof).HasColumnName("pn_sched_rshof");
            this.Property(t => t.pn_sched_pnlvl).HasColumnName("pn_sched_pnlvl");
            this.Property(t => t.pn_sched_upcnt).HasColumnName("pn_sched_upcnt");
        }
    }
}
