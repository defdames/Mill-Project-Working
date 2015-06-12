using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_export_view_op_forecastMap : EntityTypeConfiguration<advpl_export_view_op_forecast>
    {
        public advpl_export_view_op_forecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.iyear, t.imonth, t.company });

            // Properties
            this.Property(t => t.iyear)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.imonth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.product)
                .HasMaxLength(256);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(50);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("advpl_export_view_op_forecast");
            this.Property(t => t.iyear).HasColumnName("iyear");
            this.Property(t => t.imonth).HasColumnName("imonth");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.quantity).HasColumnName("quantity");
        }
    }
}
