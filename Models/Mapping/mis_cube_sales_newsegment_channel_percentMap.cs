using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_newsegment_channel_percentMap : EntityTypeConfiguration<mis_cube_sales_newsegment_channel_percent>
    {
        public mis_cube_sales_newsegment_channel_percentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.datesold_year, t.company, t.en_ship_key, t.product });

            // Properties
            this.Property(t => t.datesold_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.market)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_newsegment_channel_percent");
            this.Property(t => t.datesold_year).HasColumnName("datesold_year");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.channel_percent).HasColumnName("channel_percent");
        }
    }
}
