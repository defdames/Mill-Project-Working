using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_entty_tblMap : EntityTypeConfiguration<pn_entty_tbl>
    {
        public pn_entty_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.in_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_entty_sourc)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("pn_entty_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_entty_sourc).HasColumnName("pn_entty_sourc");
            this.Property(t => t.pn_entty_pdmdtot).HasColumnName("pn_entty_pdmdtot");
            this.Property(t => t.pn_entty_pspytot).HasColumnName("pn_entty_pspytot");
            this.Property(t => t.pn_entty_nqoh).HasColumnName("pn_entty_nqoh");
            this.Property(t => t.pn_entty_upcnt).HasColumnName("pn_entty_upcnt");
        }
    }
}
