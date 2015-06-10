using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2010_forecast_oldMap : EntityTypeConfiguration<mis_cube_salesfcst_2010_forecast_old>
    {
        public mis_cube_salesfcst_2010_forecast_oldMap()
        {
            // Primary Key
            this.HasKey(t => t.DateSold);

            // Properties
            this.Property(t => t.DateSold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Product)
                .HasMaxLength(255);

            this.Property(t => t.DomForSam)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2010_forecast_old");
            this.Property(t => t.DateSold).HasColumnName("DateSold");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.DomForSam).HasColumnName("DomForSam");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
        }
    }
}
