using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class plant_mill_hour_producedMap : EntityTypeConfiguration<plant_mill_hour_produced>
    {
        public plant_mill_hour_producedMap()
        {
            // Primary Key
            this.HasKey(t => t.sf_plant_key);

            // Properties
            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("plant_mill_hour_produced");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.forecast).HasColumnName("forecast");
            this.Property(t => t.actual).HasColumnName("actual");
        }
    }
}
