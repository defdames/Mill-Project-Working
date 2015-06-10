using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class buyer_activity_summary_dtlMap : EntityTypeConfiguration<buyer_activity_summary_dtl>
    {
        public buyer_activity_summary_dtlMap()
        {
            // Primary Key
            this.HasKey(t => t.po_hdr_key);

            // Properties
            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("buyer_activity_summary_dtl");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
        }
    }
}
