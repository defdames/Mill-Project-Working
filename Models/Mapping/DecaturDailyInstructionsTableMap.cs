using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class DecaturDailyInstructionsTableMap : EntityTypeConfiguration<DecaturDailyInstructionsTable>
    {
        public DecaturDailyInstructionsTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.System, t.Grade, t.Date });

            // Properties
            this.Property(t => t.System)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Supervisors)
                .HasMaxLength(50);

            this.Property(t => t.Crew)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DecaturDailyInstructionsTable");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.Instructions).HasColumnName("Instructions");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Supervisors).HasColumnName("Supervisors");
            this.Property(t => t.Crew).HasColumnName("Crew");
        }
    }
}
