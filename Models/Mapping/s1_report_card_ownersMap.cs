using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class s1_report_card_ownersMap : EntityTypeConfiguration<s1_report_card_owners>
    {
        public s1_report_card_ownersMap()
        {
            // Primary Key
            this.HasKey(t => t.owner);

            // Properties
            this.Property(t => t.owner)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.salesman)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("s1_report_card_owners");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.salesman).HasColumnName("salesman");
        }
    }
}
