using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class car_blend_notificationMap : EntityTypeConfiguration<car_blend_notification>
    {
        public car_blend_notificationMap()
        {
            // Primary Key
            this.HasKey(t => t.Car_No);

            // Properties
            this.Property(t => t.Grade_Name)
                .HasMaxLength(255);

            this.Property(t => t.Lot_Number)
                .HasMaxLength(255);

            this.Property(t => t.Plant)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("car_blend_notification");
            this.Property(t => t.Car_No).HasColumnName("Car No");
            this.Property(t => t.Grade_Name).HasColumnName("Grade Name");
            this.Property(t => t.Lot_Number).HasColumnName("Lot Number");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.numofdays).HasColumnName("numofdays");
        }
    }
}
