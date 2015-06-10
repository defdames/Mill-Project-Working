using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class AttendanceMap : EntityTypeConfiguration<Attendance>
    {
        public AttendanceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Employee_Name, t.Date, t.Reason });

            // Properties
            this.Property(t => t.Employee_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Reason)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remarks)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Attendance");
            this.Property(t => t.Employee_Name).HasColumnName("Employee Name");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.Time_Missed).HasColumnName("Time Missed");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Days_Used).HasColumnName("Days Used");
            this.Property(t => t.Vac_Hrs_Pd).HasColumnName("Vac Hrs Pd");
        }
    }
}
