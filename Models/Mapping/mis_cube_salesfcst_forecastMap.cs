using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_forecastMap : EntityTypeConfiguration<mis_cube_salesfcst_forecast>
    {
        public mis_cube_salesfcst_forecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DateSold, t.Company, t.Act_Fcst });

            // Properties
            this.Property(t => t.DateSold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Product)
                .HasMaxLength(255);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .HasMaxLength(255);

            this.Property(t => t.ItemClass)
                .HasMaxLength(5);

            this.Property(t => t.DomForSam)
                .HasMaxLength(255);

            this.Property(t => t.Act_Fcst)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.region)
                .HasMaxLength(20);

            this.Property(t => t.market)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_forecast");
            this.Property(t => t.DateSold).HasColumnName("DateSold");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.ItemClass).HasColumnName("ItemClass");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.GlobalCost).HasColumnName("GlobalCost");
            this.Property(t => t.DomForSam).HasColumnName("DomForSam");
            this.Property(t => t.Act_Fcst).HasColumnName("Act_Fcst");
            this.Property(t => t.MatlValue).HasColumnName("MatlValue");
            this.Property(t => t.RsrcValue).HasColumnName("RsrcValue");
            this.Property(t => t.EUROS).HasColumnName("EUROS");
            this.Property(t => t.PriorCostValue).HasColumnName("PriorCostValue");
            this.Property(t => t.PriorMatlValue).HasColumnName("PriorMatlValue");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.gl_crcnv_rate).HasColumnName("gl_crcnv_rate");
        }
    }
}
