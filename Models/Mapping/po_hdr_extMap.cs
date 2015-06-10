using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_hdr_extMap : EntityTypeConfiguration<po_hdr_ext>
    {
        public po_hdr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ltd_po_number)
                .HasMaxLength(10);

            this.Property(t => t.o_direct_ship)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_hdr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.ltd_po_number).HasColumnName("ltd_po_number");
            this.Property(t => t.o_direct_ship).HasColumnName("o_direct_ship");
            this.Property(t => t.po_hdr_upcnt).HasColumnName("po_hdr_upcnt");
            this.Property(t => t.po_hdr_shsdt).HasColumnName("po_hdr_shsdt");
        }
    }
}
