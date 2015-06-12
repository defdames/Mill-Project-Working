using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_pick_tblMap : EntityTypeConfiguration<in_pick_tbl>
    {
        public in_pick_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_pick_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_pick_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("in_pick_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_pick_key).HasColumnName("in_pick_key");
            this.Property(t => t.in_pick_stats).HasColumnName("in_pick_stats");
            this.Property(t => t.in_pick_entdt).HasColumnName("in_pick_entdt");
            this.Property(t => t.in_pick_prtdt).HasColumnName("in_pick_prtdt");
            this.Property(t => t.in_pick_clsdt).HasColumnName("in_pick_clsdt");
            this.Property(t => t.in_pick_upcnt).HasColumnName("in_pick_upcnt");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
        }
    }
}
