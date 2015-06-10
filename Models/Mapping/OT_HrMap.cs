using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class OT_HrMap : EntityTypeConfiguration<OT_Hr>
    {
        public OT_HrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.clock, t.Date });

            // Properties
            this.Property(t => t.Reason)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OT Hrs");
            this.Property(t => t.clock).HasColumnName("clock");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Refused).HasColumnName("Refused");
            this.Property(t => t.Worked).HasColumnName("Worked");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.TimeMissed).HasColumnName("TimeMissed");
        }
    }
}
