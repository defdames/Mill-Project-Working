using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_newsegment_daily_pictureMap : EntityTypeConfiguration<mis_cube_salesfcst_newsegment_daily_picture>
    {
        public mis_cube_salesfcst_newsegment_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Act_Fcst, t.InterCoRegion, t.market });

            // Properties
            this.Property(t => t.DateSold)
                .HasMaxLength(30);

            this.Property(t => t.Product)
                .HasMaxLength(255);

            this.Property(t => t.Company)
                .HasMaxLength(500);

            this.Property(t => t.Item)
                .HasMaxLength(255);

            this.Property(t => t.ItemClass)
                .HasMaxLength(5);

            this.Property(t => t.DomForSam)
                .HasMaxLength(255);

            this.Property(t => t.Act_Fcst)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.InterCoRegion)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.market)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.salesmgr)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_newsegment_daily_picture");
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
            this.Property(t => t.DirectLabor).HasColumnName("DirectLabor");
            this.Property(t => t.VariableCost).HasColumnName("VariableCost");
            this.Property(t => t.FixedCost).HasColumnName("FixedCost");
            this.Property(t => t.InterCoRegion).HasColumnName("InterCoRegion");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.salesmgr).HasColumnName("salesmgr");
        }
    }
}
