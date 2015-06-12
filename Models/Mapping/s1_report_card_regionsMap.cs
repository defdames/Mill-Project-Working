using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class s1_report_card_regionsMap : EntityTypeConfiguration<s1_report_card_regions>
    {
        public s1_report_card_regionsMap()
        {
            // Primary Key
            this.HasKey(t => t.region);

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("s1_report_card_regions");
            this.Property(t => t.region).HasColumnName("region");
        }
    }
}
