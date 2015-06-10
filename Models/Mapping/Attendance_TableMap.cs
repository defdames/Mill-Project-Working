using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Attendance_TableMap : EntityTypeConfiguration<Attendance_Table>
    {
        public Attendance_TableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Clock, t.Date, t.Reason });

            // Properties
            this.Property(t => t.Reason)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Attendance Table");
            this.Property(t => t.Clock).HasColumnName("Clock");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.Time_Missed).HasColumnName("Time Missed");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
        }
    }
}
