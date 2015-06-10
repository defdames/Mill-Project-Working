using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class astquickreceiptnotopen_viewMap : EntityTypeConfiguration<astquickreceiptnotopen_view>
    {
        public astquickreceiptnotopen_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.so_brnch_key, t.ar_gl_cmp_key, t.ar_ship_key, t.so_hdr_key, t.so_cpono, t.so_dtl_key, t.so_prod_key, t.in_item_key, t.im_pack_key, t.in_prod_uom, t.shippedqty, t.po_hdr_stats });

            // Properties
            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_prod_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_hdr_stats)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.po_im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.po_dtl_uom)
                .HasMaxLength(2);

            this.Property(t => t.po_co)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("astquickreceiptnotopen_view");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_gl_cmp_key).HasColumnName("ar_gl_cmp_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_cpono).HasColumnName("so_cpono");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_prod_uom).HasColumnName("in_prod_uom");
            this.Property(t => t.shippedqty).HasColumnName("shippedqty");
            this.Property(t => t.po_hdr_stats).HasColumnName("po_hdr_stats");
            this.Property(t => t.po_hdr_clsdt).HasColumnName("po_hdr_clsdt");
            this.Property(t => t.po_in_item_key).HasColumnName("po_in_item_key");
            this.Property(t => t.po_im_pack_key).HasColumnName("po_im_pack_key");
            this.Property(t => t.po_dtl_uom).HasColumnName("po_dtl_uom");
            this.Property(t => t.po_dtl_stats).HasColumnName("po_dtl_stats");
            this.Property(t => t.po_dtl_Clsdt).HasColumnName("po_dtl_Clsdt");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.po_co).HasColumnName("po_co");
        }
    }
}
