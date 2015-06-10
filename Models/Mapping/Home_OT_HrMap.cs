using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Home_OT_HrMap : EntityTypeConfiguration<Home_OT_Hr>
    {
        public Home_OT_HrMap()
        {
            // Primary Key
            this.HasKey(t => t.primarykey);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(50);

            this.Property(t => t.Dept)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Home OT Hrs");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.clock).HasColumnName("clock");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Refused).HasColumnName("Refused");
            this.Property(t => t.Adjusted_Hrs).HasColumnName("Adjusted Hrs");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Worked).HasColumnName("Worked");
            this.Property(t => t.Night_Worked).HasColumnName("Night Worked");
            this.Property(t => t.Night_Refused).HasColumnName("Night Refused");
            this.Property(t => t.Dept).HasColumnName("Dept");
            this.Property(t => t.primarykey).HasColumnName("primarykey");
        }
    }
}
