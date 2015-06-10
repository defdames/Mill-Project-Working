using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2012_forecastMap : EntityTypeConfiguration<mis_cube_salesfcst_2012_forecast>
    {
        public mis_cube_salesfcst_2012_forecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.CostValue, t.KGS, t.GlobalCost, t.Act_FCST, t.MatlValue, t.RsrcValue, t.EUROS, t.region });

            // Properties
            this.Property(t => t.DateSold)
                .HasMaxLength(11);

            this.Property(t => t.Product)
                .HasMaxLength(200);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .HasMaxLength(30);

            this.Property(t => t.ItemClass)
                .HasMaxLength(30);

            this.Property(t => t.CostValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KGS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GlobalCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DomForSam)
                .HasMaxLength(13);

            this.Property(t => t.Act_FCST)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.MatlValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RsrcValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EUROS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.market)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2012_forecast");
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
            this.Property(t => t.Act_FCST).HasColumnName("Act_FCST");
            this.Property(t => t.MatlValue).HasColumnName("MatlValue");
            this.Property(t => t.RsrcValue).HasColumnName("RsrcValue");
            this.Property(t => t.EUROS).HasColumnName("EUROS");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.market).HasColumnName("market");
        }
    }
}
