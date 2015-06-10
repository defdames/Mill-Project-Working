using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_alloc_tblMap : EntityTypeConfiguration<in_alloc_tbl>
    {
        public in_alloc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.in_lot_key, t.in_alloc_entid, t.in_alloc_ordtp, t.gl_cmp_demand, t.in_alloc_ordid, t.in_alloc_line, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_alloc_entid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_alloc_ordtp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_cmp_demand)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_alloc_ordid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_alloc_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("in_alloc_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_alloc_entid).HasColumnName("in_alloc_entid");
            this.Property(t => t.in_alloc_ordtp).HasColumnName("in_alloc_ordtp");
            this.Property(t => t.gl_cmp_demand).HasColumnName("gl_cmp_demand");
            this.Property(t => t.in_alloc_ordid).HasColumnName("in_alloc_ordid");
            this.Property(t => t.in_alloc_line).HasColumnName("in_alloc_line");
            this.Property(t => t.in_alloc_qty).HasColumnName("in_alloc_qty");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_alloc_upcnt).HasColumnName("in_alloc_upcnt");
        }
    }
}
