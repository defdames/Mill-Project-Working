using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_lot_tblMap : EntityTypeConfiguration<en_lot_tbl>
    {
        public en_lot_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.en_lot_key });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_vend_key)
                .HasMaxLength(10);

            this.Property(t => t.en_lot_extlt)
                .HasMaxLength(25);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .HasMaxLength(4);

            this.Property(t => t.sf_plant_key)
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.pm_shop_key)
                .HasMaxLength(10);

            this.Property(t => t.qc_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_grade_key)
                .HasMaxLength(10);

            this.Property(t => t.en_lot_text)
                .HasMaxLength(255);

            this.Property(t => t.en_hold_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_lot_cool)
                .HasMaxLength(255);

            this.Property(t => t.qc_source_key)
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("en_lot_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_lot_extlt).HasColumnName("en_lot_extlt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.en_lot_mfgdt).HasColumnName("en_lot_mfgdt");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.en_lot_smpdt).HasColumnName("en_lot_smpdt");
            this.Property(t => t.en_lot_crtdt).HasColumnName("en_lot_crtdt");
            this.Property(t => t.en_lot_expdt).HasColumnName("en_lot_expdt");
            this.Property(t => t.en_lot_fidt).HasColumnName("en_lot_fidt");
            this.Property(t => t.en_lot_pri).HasColumnName("en_lot_pri");
            this.Property(t => t.en_lot_pot).HasColumnName("en_lot_pot");
            this.Property(t => t.en_lot_aprdt).HasColumnName("en_lot_aprdt");
            this.Property(t => t.en_lot_rejdt).HasColumnName("en_lot_rejdt");
            this.Property(t => t.en_lot_hlddt).HasColumnName("en_lot_hlddt");
            this.Property(t => t.qc_stats_key).HasColumnName("qc_stats_key");
            this.Property(t => t.en_grade_key).HasColumnName("en_grade_key");
            this.Property(t => t.en_lot_text).HasColumnName("en_lot_text");
            this.Property(t => t.en_hold_key).HasColumnName("en_hold_key");
            this.Property(t => t.en_lot_type).HasColumnName("en_lot_type");
            this.Property(t => t.en_lot_upcnt).HasColumnName("en_lot_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_lot_chgdt).HasColumnName("en_lot_chgdt");
            this.Property(t => t.en_lot_cool).HasColumnName("en_lot_cool");
            this.Property(t => t.qc_source_key).HasColumnName("qc_source_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
        }
    }
}
