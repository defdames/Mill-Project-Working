using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PO_RECPT_extMap : EntityTypeConfiguration<PO_RECPT_ext>
    {
        public PO_RECPT_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_recpt_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_vessel)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PO_RECPT_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_recpt_vessel).HasColumnName("po_recpt_vessel");
            this.Property(t => t.po_recpt_vesdt).HasColumnName("po_recpt_vesdt");
            this.Property(t => t.PO_RECPT_upcnt).HasColumnName("PO_RECPT_upcnt");
        }
    }
}
