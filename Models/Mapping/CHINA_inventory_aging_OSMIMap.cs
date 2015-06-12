using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_inventory_aging_OSMIMap : EntityTypeConfiguration<CHINA_inventory_aging_OSMI>
    {
        public CHINA_inventory_aging_OSMIMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.in_whs_key, t.in_lot_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_comcd_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_ituse_key)
                .HasMaxLength(10);

            this.Property(t => t.in_abcc)
                .HasMaxLength(2);

            this.Property(t => t.ItemStatus)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_inventory_aging_OSMI");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
            this.Property(t => t.in_whitmpk_scst).HasColumnName("in_whitmpk_scst");
            this.Property(t => t.en_lot_mfgdt).HasColumnName("en_lot_mfgdt");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.pounds).HasColumnName("pounds");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_ituse_key).HasColumnName("en_ituse_key");
            this.Property(t => t.in_abcc).HasColumnName("in_abcc");
            this.Property(t => t.ItemStatus).HasColumnName("ItemStatus");
            this.Property(t => t.lb_in_lot_qoh).HasColumnName("lb_in_lot_qoh");
            this.Property(t => t.ext_cost).HasColumnName("ext_cost");
            this.Property(t => t.kg_in_lot_qoh).HasColumnName("kg_in_lot_qoh");
        }
    }
}
