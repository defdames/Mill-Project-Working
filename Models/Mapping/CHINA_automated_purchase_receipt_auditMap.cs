using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_automated_purchase_receipt_auditMap : EntityTypeConfiguration<CHINA_automated_purchase_receipt_audit>
    {
        public CHINA_automated_purchase_receipt_auditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key, t.im_pack_key, t.in_lot_key, t.in_tran_qty, t.in_tran_demandid, t.in_whs_key, t.in_locn_key, t.Invoice_Price });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.im_pack_uom)
                .HasMaxLength(2);

            this.Property(t => t.in_tran_demandid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_shprf)
                .HasMaxLength(20);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_key)
                .HasMaxLength(10);

            this.Property(t => t.in_desc)
                .HasMaxLength(60);

            this.Property(t => t.xen_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.Invoice_Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CHINA_automated_purchase_receipt_audit");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_tran_qty).HasColumnName("in_tran_qty");
            this.Property(t => t.im_pack_uom).HasColumnName("im_pack_uom");
            this.Property(t => t.in_tran_demandid).HasColumnName("in_tran_demandid");
            this.Property(t => t.po_recpt_shprf).HasColumnName("po_recpt_shprf");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_tran_date).HasColumnName("in_tran_date");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.xen_prod_key).HasColumnName("xen_prod_key");
            this.Property(t => t.Invoice_Price).HasColumnName("Invoice_Price");
        }
    }
}
