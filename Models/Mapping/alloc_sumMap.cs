using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class alloc_sumMap : EntityTypeConfiguration<alloc_sum>
    {
        public alloc_sumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_key, t.im_pack_key, t.in_lot_key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("alloc_sum");
            this.Property(t => t.allocqty).HasColumnName("allocqty");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
        }
    }
}
