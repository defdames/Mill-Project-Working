using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_cntrdtl_tblMap : EntityTypeConfiguration<in_cntrdtl_tbl>
    {
        public in_cntrdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.en_pkgtyp_key, t.en_mfrid_key, t.in_cntrhdr_srlno, t.in_cntrhdr_ckdgt, t.in_pick_key, t.in_pkpeg_key, t.in_lot_key, t.in_locn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_pkgtyp_key)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_mfrid_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cntrhdr_srlno)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.in_cntrhdr_ckdgt)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_pick_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_pkpeg_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_cntrdtl_ordtyp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_cntrdtl_ordno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cntrdtl_ordent)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_demand)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("in_cntrdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_pkgtyp_key).HasColumnName("en_pkgtyp_key");
            this.Property(t => t.en_mfrid_key).HasColumnName("en_mfrid_key");
            this.Property(t => t.in_cntrhdr_srlno).HasColumnName("in_cntrhdr_srlno");
            this.Property(t => t.in_cntrhdr_ckdgt).HasColumnName("in_cntrhdr_ckdgt");
            this.Property(t => t.in_pick_key).HasColumnName("in_pick_key");
            this.Property(t => t.in_pkpeg_key).HasColumnName("in_pkpeg_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_cntrdtl_qty).HasColumnName("in_cntrdtl_qty");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.in_cntrdtl_ordtyp).HasColumnName("in_cntrdtl_ordtyp");
            this.Property(t => t.in_cntrdtl_ordno).HasColumnName("in_cntrdtl_ordno");
            this.Property(t => t.in_cntrdtl_ordln).HasColumnName("in_cntrdtl_ordln");
            this.Property(t => t.in_cntrdtl_ordent).HasColumnName("in_cntrdtl_ordent");
            this.Property(t => t.in_cntrdtl_upcnt).HasColumnName("in_cntrdtl_upcnt");
            this.Property(t => t.gl_cmp_demand).HasColumnName("gl_cmp_demand");
        }
    }
}
