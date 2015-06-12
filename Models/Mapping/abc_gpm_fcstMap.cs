using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_fcstMap : EntityTypeConfiguration<abc_gpm_fcst>
    {
        public abc_gpm_fcstMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_fcst");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.Forecast).HasColumnName("Forecast");
        }
    }
}
