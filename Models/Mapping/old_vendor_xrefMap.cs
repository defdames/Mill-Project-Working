using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class old_vendor_xrefMap : EntityTypeConfiguration<old_vendor_xref>
    {
        public old_vendor_xrefMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OLD, t.NEW });

            // Properties
            this.Property(t => t.OLD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NEW)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("old_vendor_xref");
            this.Property(t => t.OLD).HasColumnName("OLD");
            this.Property(t => t.NEW).HasColumnName("NEW");
        }
    }
}
