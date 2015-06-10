using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Lnumber_MarketingTableMap : EntityTypeConfiguration<Lnumber_MarketingTable>
    {
        public Lnumber_MarketingTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Key, t.source });

            // Properties
            this.Property(t => t.Key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Market_Class_Code)
                .HasMaxLength(50);

            this.Property(t => t.Trade_Name)
                .HasMaxLength(50);

            this.Property(t => t.Standard_Pack)
                .HasMaxLength(50);

            this.Property(t => t.source)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lnumber MarketingTable");
            this.Property(t => t.Key).HasColumnName("Key");
            this.Property(t => t.Market_Class_Code).HasColumnName("Market Class Code");
            this.Property(t => t.Trade_Name).HasColumnName("Trade Name");
            this.Property(t => t.Trade_Name_Date).HasColumnName("Trade Name Date");
            this.Property(t => t.Original_Price_Date).HasColumnName("Original Price Date");
            this.Property(t => t.Drum_Original_Price).HasColumnName("Drum Original Price");
            this.Property(t => t.Truck_Original_Price).HasColumnName("Truck Original Price");
            this.Property(t => t.Current_Price_Date).HasColumnName("Current Price Date");
            this.Property(t => t.Drum_Current_Price).HasColumnName("Drum Current Price");
            this.Property(t => t.Truck_Current_Price).HasColumnName("Truck Current Price");
            this.Property(t => t.Standard_Pack).HasColumnName("Standard Pack");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");
            this.Property(t => t.Discontinued_Date).HasColumnName("Discontinued Date");
            this.Property(t => t.Sales_Marketing_Comments).HasColumnName("Sales/Marketing Comments");
            this.Property(t => t.source).HasColumnName("source");
        }
    }
}
