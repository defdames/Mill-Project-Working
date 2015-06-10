using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_export_view_op_forecast_vs_actualMap : EntityTypeConfiguration<advpl_export_view_op_forecast_vs_actual>
    {
        public advpl_export_view_op_forecast_vs_actualMap()
        {
            // Primary Key
            this.HasKey(t => new { t.top_customer_name, t.Salesmgr });

            // Properties
            this.Property(t => t.company)
                .HasMaxLength(500);

            this.Property(t => t.shipkey)
                .HasMaxLength(50);

            this.Property(t => t.location)
                .HasMaxLength(41);

            this.Property(t => t.en_ship_name)
                .HasMaxLength(30);

            this.Property(t => t.product)
                .HasMaxLength(256);

            this.Property(t => t.en_prod_desc)
                .HasMaxLength(60);

            this.Property(t => t.top_customer_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Salesmgr)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("advpl_export_view_op_forecast_vs_actual");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.iyear).HasColumnName("iyear");
            this.Property(t => t.imonth).HasColumnName("imonth");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.Salesmgr).HasColumnName("Salesmgr");
            this.Property(t => t.actual).HasColumnName("actual");
            this.Property(t => t.forecast).HasColumnName("forecast");
            this.Property(t => t.variance).HasColumnName("variance");
        }
    }
}
