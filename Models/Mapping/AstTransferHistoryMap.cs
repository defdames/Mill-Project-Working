using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class AstTransferHistoryMap : EntityTypeConfiguration<AstTransferHistory>
    {
        public AstTransferHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TransferHistoryId);

            // Properties
            this.Property(t => t.CompanyKey)
                .HasMaxLength(2);

            this.Property(t => t.WarehouseKey)
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .HasMaxLength(20);

            this.Property(t => t.po_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.Im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.in_locn_from)
                .HasMaxLength(10);

            this.Property(t => t.in_locn_to)
                .HasMaxLength(10);

            this.Property(t => t.en_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.Sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("AstTransferHistory");
            this.Property(t => t.TransferHistoryId).HasColumnName("TransferHistoryId");
            this.Property(t => t.CompanyKey).HasColumnName("CompanyKey");
            this.Property(t => t.WarehouseKey).HasColumnName("WarehouseKey");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.Im_pack_key).HasColumnName("Im_pack_key");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.in_locn_from).HasColumnName("in_locn_from");
            this.Property(t => t.in_locn_to).HasColumnName("in_locn_to");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.Sa_user_key).HasColumnName("Sa_user_key");
            this.Property(t => t.transactiondate).HasColumnName("transactiondate");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
        }
    }
}
