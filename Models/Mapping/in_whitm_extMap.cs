using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whitm_extMap : EntityTypeConfiguration<in_whitm_ext>
    {
        public in_whitm_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key });

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

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_itgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ruser_initials)
                .HasMaxLength(4);

            this.Property(t => t.slifo_year)
                .HasMaxLength(4);

            this.Property(t => t.remarks)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("in_whitm_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_itgrp_key).HasColumnName("in_itgrp_key");
            this.Property(t => t.nonvolatile).HasColumnName("nonvolatile");
            this.Property(t => t.percent_metal).HasColumnName("percent_metal");
            this.Property(t => t.qcost_last_reviewed_date).HasColumnName("qcost_last_reviewed_date");
            this.Property(t => t.ruser_initials).HasColumnName("ruser_initials");
            this.Property(t => t.slifo_cost).HasColumnName("slifo_cost");
            this.Property(t => t.slifo_year).HasColumnName("slifo_year");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.in_whitm_upcnt).HasColumnName("in_whitm_upcnt");
        }
    }
}
