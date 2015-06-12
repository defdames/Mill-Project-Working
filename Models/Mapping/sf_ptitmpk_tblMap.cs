using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ptitmpk_tblMap : EntityTypeConfiguration<sf_ptitmpk_tbl>
    {
        public sf_ptitmpk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.im_pack_key, t.sf_rout_key, t.sf_ptitmpk_effdt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.in_locgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.sf_ptitmpk_astplid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("sf_ptitmpk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_ptitmpk_effdt).HasColumnName("sf_ptitmpk_effdt");
            this.Property(t => t.sf_ptitmpk_inadt).HasColumnName("sf_ptitmpk_inadt");
            this.Property(t => t.sf_ptitmpk_yldfac).HasColumnName("sf_ptitmpk_yldfac");
            this.Property(t => t.sf_ptitmpk_rttype).HasColumnName("sf_ptitmpk_rttype");
            this.Property(t => t.sf_ptitmpk_pstpver).HasColumnName("sf_ptitmpk_pstpver");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locgrp_key).HasColumnName("in_locgrp_key");
            this.Property(t => t.sf_ptitmpk_astplid).HasColumnName("sf_ptitmpk_astplid");
            this.Property(t => t.sf_ptitmpk_upcnt).HasColumnName("sf_ptitmpk_upcnt");
        }
    }
}
