using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_inventory_by_lotMap : EntityTypeConfiguration<CHINA_inventory_by_lot>
    {
        public CHINA_inventory_by_lotMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_Key, t.in_item_key, t.in_lot_key, t.in_lot_qoh, t.in_locn_key, t.in_whs_key });

            // Properties
            this.Property(t => t.gl_cmp_Key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.packing)
                .HasMaxLength(9);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whs_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CHINA_inventory_by_lot");
            this.Property(t => t.gl_cmp_Key).HasColumnName("gl_cmp_Key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.packing).HasColumnName("packing");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.in_whitmpk_scst).HasColumnName("in_whitmpk_scst");
            this.Property(t => t.totald).HasColumnName("totald");
            this.Property(t => t.ex_rate).HasColumnName("ex rate");
            this.Property(t => t.sing).HasColumnName("sing");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_whs_name).HasColumnName("in_whs_name");
        }
    }
}
