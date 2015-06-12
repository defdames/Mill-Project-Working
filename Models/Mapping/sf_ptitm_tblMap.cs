using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ptitm_tblMap : EntityTypeConfiguration<sf_ptitm_tbl>
    {
        public sf_ptitm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key });

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

            this.Property(t => t.sf_mfgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bm_aprt_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_plnc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.multilvl_flag)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_asprdgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.in_spritm_asprd)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("sf_ptitm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.sf_mfgrp_key).HasColumnName("sf_mfgrp_key");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.bm_aprt_key).HasColumnName("bm_aprt_key");
            this.Property(t => t.sf_ptitm_mmthd).HasColumnName("sf_ptitm_mmthd");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.in_plnc_key).HasColumnName("in_plnc_key");
            this.Property(t => t.in_bldt).HasColumnName("in_bldt");
            this.Property(t => t.in_uldt).HasColumnName("in_uldt");
            this.Property(t => t.in_yldf).HasColumnName("in_yldf");
            this.Property(t => t.in_wipq).HasColumnName("in_wipq");
            this.Property(t => t.in_wipaq).HasColumnName("in_wipaq");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_wiss).HasColumnName("in_wiss");
            this.Property(t => t.multilvl_flag).HasColumnName("multilvl_flag");
            this.Property(t => t.sf_ptitm_advplnf).HasColumnName("sf_ptitm_advplnf");
            this.Property(t => t.sf_ptitm_advschf).HasColumnName("sf_ptitm_advschf");
            this.Property(t => t.sf_ptitm_type).HasColumnName("sf_ptitm_type");
            this.Property(t => t.sf_asprdgrp_key).HasColumnName("sf_asprdgrp_key");
            this.Property(t => t.sf_ptitm_prdschf).HasColumnName("sf_ptitm_prdschf");
            this.Property(t => t.sf_ptitm_asdlvrf).HasColumnName("sf_ptitm_asdlvrf");
            this.Property(t => t.sf_ptitm_upcnt).HasColumnName("sf_ptitm_upcnt");
            this.Property(t => t.in_spritm_asprd).HasColumnName("in_spritm_asprd");
        }
    }
}
