using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_locgrp_tblMap : EntityTypeConfiguration<in_locgrp_tbl>
    {
        public in_locgrp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_locgrp_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_locgrp_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("in_locgrp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locgrp_key).HasColumnName("in_locgrp_key");
            this.Property(t => t.in_locgrp_desc).HasColumnName("in_locgrp_desc");
            this.Property(t => t.in_locgrp_tankf).HasColumnName("in_locgrp_tankf");
            this.Property(t => t.in_locgrp_crtdt).HasColumnName("in_locgrp_crtdt");
            this.Property(t => t.in_locgrp_chgdt).HasColumnName("in_locgrp_chgdt");
            this.Property(t => t.in_locgrp_upcnt).HasColumnName("in_locgrp_upcnt");
            this.Property(t => t.in_locgrp_cycntf).HasColumnName("in_locgrp_cycntf");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
