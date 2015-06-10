using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_prcss_tblMap : EntityTypeConfiguration<sf_prcss_tbl>
    {
        public sf_prcss_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_prcss_key, t.sf_prcss_ver, t.sf_frmla_key, t.sf_frmla_ver, t.sf_rout_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_prcss_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_locgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.sf_prcss_astplid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("sf_prcss_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_prcss_desc).HasColumnName("sf_prcss_desc");
            this.Property(t => t.sf_prcss_stat).HasColumnName("sf_prcss_stat");
            this.Property(t => t.sf_prcss_advplnf).HasColumnName("sf_prcss_advplnf");
            this.Property(t => t.sf_prcss_advschf).HasColumnName("sf_prcss_advschf");
            this.Property(t => t.sf_prcss_pstpver).HasColumnName("sf_prcss_pstpver");
            this.Property(t => t.in_locgrp_key).HasColumnName("in_locgrp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.sf_prcss_astplid).HasColumnName("sf_prcss_astplid");
            this.Property(t => t.sf_prcss_upcnt).HasColumnName("sf_prcss_upcnt");
        }
    }
}
