using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAcompetitionMap : EntityTypeConfiguration<PDAcompetition>
    {
        public PDAcompetitionMap()
        {
            // Primary Key
            this.HasKey(t => t.COMPETITOR);

            // Properties
            this.Property(t => t.COMPETITOR)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PDAcompetition");
            this.Property(t => t.COMPETITOR).HasColumnName("COMPETITOR");
        }
    }
}
