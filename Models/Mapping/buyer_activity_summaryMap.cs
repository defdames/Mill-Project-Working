using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class buyer_activity_summaryMap : EntityTypeConfiguration<buyer_activity_summary>
    {
        public buyer_activity_summaryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.po_hdr_key, t.in_buyc, t.po_hdr_orddt });

            // Properties
            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_buyc)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("buyer_activity_summary");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.in_buyc).HasColumnName("in_buyc");
            this.Property(t => t.po_hdr_orddt).HasColumnName("po_hdr_orddt");
            this.Property(t => t.dollars).HasColumnName("dollars");
        }
    }
}
