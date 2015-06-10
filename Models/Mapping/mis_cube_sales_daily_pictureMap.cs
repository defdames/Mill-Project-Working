using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_daily_pictureMap : EntityTypeConfiguration<mis_cube_sales_daily_picture>
    {
        public mis_cube_sales_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ship_Whse, t.Act_Fcst, t.SALESMGR });

            // Properties
            this.Property(t => t.DateSold)
                .HasMaxLength(30);

            this.Property(t => t.Product)
                .HasMaxLength(50);

            this.Property(t => t.ShipKey)
                .HasMaxLength(500);

            this.Property(t => t.Company)
                .HasMaxLength(500);

            this.Property(t => t.PackKey)
                .HasMaxLength(6);

            this.Property(t => t.Agent)
                .HasMaxLength(45);

            this.Property(t => t.Item)
                .HasMaxLength(20);

            this.Property(t => t.ItemClass)
                .HasMaxLength(5);

            this.Property(t => t.ManufacturingLoc)
                .HasMaxLength(500);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.SoldTo)
                .HasMaxLength(41);

            this.Property(t => t.whseacct)
                .HasMaxLength(50);

            this.Property(t => t.CityState)
                .HasMaxLength(31);

            this.Property(t => t.shipname)
                .HasMaxLength(62);

            this.Property(t => t.DomForSam)
                .HasMaxLength(14);

            this.Property(t => t.Ship_Whse)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Act_Fcst)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SALESMGR)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_daily_picture");
            this.Property(t => t.DateSold).HasColumnName("DateSold");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.ShipKey).HasColumnName("ShipKey");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.ItemClass).HasColumnName("ItemClass");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.GlobalCost).HasColumnName("GlobalCost");
            this.Property(t => t.GlobalMatlValue).HasColumnName("GlobalMatlValue");
            this.Property(t => t.GlobalDirectLabor).HasColumnName("GlobalDirectLabor");
            this.Property(t => t.GlobalVariableCost).HasColumnName("GlobalVariableCost");
            this.Property(t => t.ManufacturingLoc).HasColumnName("ManufacturingLoc");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.SoldTo).HasColumnName("SoldTo");
            this.Property(t => t.whseacct).HasColumnName("whseacct");
            this.Property(t => t.CityState).HasColumnName("CityState");
            this.Property(t => t.shipname).HasColumnName("shipname");
            this.Property(t => t.DomForSam).HasColumnName("DomForSam");
            this.Property(t => t.Ship_Whse).HasColumnName("Ship_Whse");
            this.Property(t => t.Act_Fcst).HasColumnName("Act_Fcst");
            this.Property(t => t.MatlValue).HasColumnName("MatlValue");
            this.Property(t => t.RsrcValue).HasColumnName("RsrcValue");
            this.Property(t => t.EUROS).HasColumnName("EUROS");
            this.Property(t => t.DirectLabor).HasColumnName("DirectLabor");
            this.Property(t => t.VariableCost).HasColumnName("VariableCost");
            this.Property(t => t.FixedCost).HasColumnName("FixedCost");
            this.Property(t => t.SALESMGR).HasColumnName("SALESMGR");
        }
    }
}
