using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class s1_report_card_masterMap : EntityTypeConfiguration<s1_report_card_master>
    {
        public s1_report_card_masterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.region, t.customer });

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.customer)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.owner)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("s1_report_card_master");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");

            // Relationships
            this.HasRequired(t => t.s1_report_card_owners)
                .WithMany(t => t.s1_report_card_master)
                .HasForeignKey(d => d.owner);
            this.HasRequired(t => t.s1_report_card_regions)
                .WithMany(t => t.s1_report_card_master)
                .HasForeignKey(d => d.region);

        }
    }
}
