using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_rthdr_tblMap : EntityTypeConfiguration<sf_rthdr_tbl>
    {
        public sf_rthdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rout_key });

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

            this.Property(t => t.sf_rthdr_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_rthdr_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rout_typ)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rthdr_runuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_stage_key)
                .HasMaxLength(20);

            this.Property(t => t.sf_rsrcgrp_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sf_rthdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_rthdr_desc).HasColumnName("sf_rthdr_desc");
            this.Property(t => t.sf_rthdr_stat).HasColumnName("sf_rthdr_stat");
            this.Property(t => t.sf_rout_typ).HasColumnName("sf_rout_typ");
            this.Property(t => t.sf_rthdr_runsz).HasColumnName("sf_rthdr_runsz");
            this.Property(t => t.sf_rthdr_runuom).HasColumnName("sf_rthdr_runuom");
            this.Property(t => t.sf_rthdr_runtm).HasColumnName("sf_rthdr_runtm");
            this.Property(t => t.sf_stage_key).HasColumnName("sf_stage_key");
            this.Property(t => t.sf_rthdr_grptyp).HasColumnName("sf_rthdr_grptyp");
            this.Property(t => t.sf_rsrcgrp_key).HasColumnName("sf_rsrcgrp_key");
            this.Property(t => t.sf_rthdr_apthrpt).HasColumnName("sf_rthdr_apthrpt");
            this.Property(t => t.sf_rthdr_upcnt).HasColumnName("sf_rthdr_upcnt");
        }
    }
}
