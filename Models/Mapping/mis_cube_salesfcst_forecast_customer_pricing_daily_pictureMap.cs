using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_forecast_customer_pricing_daily_pictureMap : EntityTypeConfiguration<mis_cube_salesfcst_forecast_customer_pricing_daily_picture>
    {
        public mis_cube_salesfcst_forecast_customer_pricing_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pc_bsprdt_uom, t.gl_crncy_key, t.priority });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(500);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.pc_bsprdt_prod)
                .HasMaxLength(50);

            this.Property(t => t.pc_bsprdt_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_forecast_customer_pricing_daily_picture");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.pc_bsprdt_prod).HasColumnName("pc_bsprdt_prod");
            this.Property(t => t.pc_bsprdt_uom).HasColumnName("pc_bsprdt_uom");
            this.Property(t => t.pc_bsprdt_price).HasColumnName("pc_bsprdt_price");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.priority).HasColumnName("priority");
        }
    }
}
