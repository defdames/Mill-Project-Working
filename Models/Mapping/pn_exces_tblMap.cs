using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_exces_tblMap : EntityTypeConfiguration<pn_exces_tbl>
    {
        public pn_exces_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.pn_entty_sourc, t.in_item_key, t.pn_date, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_entty_sourc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_repack_fl)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pn_exces_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.pn_entty_sourc).HasColumnName("pn_entty_sourc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_date).HasColumnName("pn_date");
            this.Property(t => t.pn_qty).HasColumnName("pn_qty");
            this.Property(t => t.pn_exces_upcnt).HasColumnName("pn_exces_upcnt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_bulk_qty).HasColumnName("pn_bulk_qty");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.pn_repack_fl).HasColumnName("pn_repack_fl");
            this.Property(t => t.pn_repack_seq).HasColumnName("pn_repack_seq");
            this.Property(t => t.pn_exces_stat).HasColumnName("pn_exces_stat");
        }
    }
}
