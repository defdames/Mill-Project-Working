using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PlantMillHoursProducedDashboardForecastMap : EntityTypeConfiguration<PlantMillHoursProducedDashboardForecast>
    {
        public PlantMillHoursProducedDashboardForecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fcst_year, t.fcst_month, t.sf_plant_key });

            // Properties
            this.Property(t => t.fcst_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.fcst_month)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("PlantMillHoursProducedDashboardForecast");
            this.Property(t => t.fcst_year).HasColumnName("fcst_year");
            this.Property(t => t.fcst_month).HasColumnName("fcst_month");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.forecast).HasColumnName("forecast");
        }
    }
}
