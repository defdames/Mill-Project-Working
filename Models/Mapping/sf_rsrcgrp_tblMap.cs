using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_rsrcgrp_tblMap : EntityTypeConfiguration<sf_rsrcgrp_tbl>
    {
        public sf_rsrcgrp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rsrcgrp_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_rsrcgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rsrcgrp_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sf_rsrcgrp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rsrcgrp_key).HasColumnName("sf_rsrcgrp_key");
            this.Property(t => t.sf_rsrcgrp_desc).HasColumnName("sf_rsrcgrp_desc");
            this.Property(t => t.sf_rsrcgrp_advschf).HasColumnName("sf_rsrcgrp_advschf");
            this.Property(t => t.sf_rsrcgrp_type).HasColumnName("sf_rsrcgrp_type");
            this.Property(t => t.sf_rsrcgrp_crtdt).HasColumnName("sf_rsrcgrp_crtdt");
            this.Property(t => t.sf_rsrcgrp_chgdt).HasColumnName("sf_rsrcgrp_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sf_rsrcgrp_upcnt).HasColumnName("sf_rsrcgrp_upcnt");
        }
    }
}
