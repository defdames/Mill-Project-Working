using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MarketSegment_usrMap : EntityTypeConfiguration<MarketSegment_usr>
    {
        public MarketSegment_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.ShipTo, t.Product });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MarketSegment)
                .HasMaxLength(50);

            this.Property(t => t.SubMarket)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MarketSegment_usr");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.ShipTo).HasColumnName("ShipTo");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.MarketSegment).HasColumnName("MarketSegment");
            this.Property(t => t.SubMarket).HasColumnName("SubMarket");
        }
    }
}
