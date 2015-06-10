using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_forecast_customer_currency_ratesMap : EntityTypeConfiguration<mis_cube_salesfcst_forecast_customer_currency_rates>
    {
        public mis_cube_salesfcst_forecast_customer_currency_ratesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.forecast_year, t.gl_crncy_key });

            // Properties
            this.Property(t => t.forecast_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_forecast_customer_currency_rates");
            this.Property(t => t.forecast_year).HasColumnName("forecast_year");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.rate_from_USD).HasColumnName("rate_from_USD");
        }
    }
}
