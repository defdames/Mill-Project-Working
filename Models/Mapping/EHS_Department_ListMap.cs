using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Department_ListMap : EntityTypeConfiguration<EHS_Department_List>
    {
        public EHS_Department_ListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.location, t.department });

            // Properties
            this.Property(t => t.location)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.department)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS Department List");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.department).HasColumnName("department");
        }
    }
}
