using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_pda_master2Map : EntityTypeConfiguration<tmp_pda_master2>
    {
        public tmp_pda_master2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ApprovedBy, t.ApprovedDate, t.Market, t.ProductCode, t.Currency, t.CurrentPrice, t.NewRequested_Price, t.EffectiveDate, t.ExpirationDate, t.FreightTerms, t.Competitor, t.CompetitiveProduct, t.CompetitivePrice, t.Customer, t.ShipTo, t.ShipToName, t.ShipToCity, t.ShipToState, t.ShipToCountry, t.BillTo, t.BillToName, t.BillToCity, t.BillToState, t.BillToCountry, t.Entity, t.Break_Pallet, t.Freight_Allowance, t.Repack, t.ListPrice, t.MinimumInvoice, t.StdPack });

            // Properties
            this.Property(t => t.ApprovedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProductCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CurrentPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NewRequested_Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FreightTerms)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Competitor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompetitiveProduct)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompetitivePrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Customer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipToName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipToCity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipToState)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipToCountry)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToCity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToState)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToCountry)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Entity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Break_Pallet)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Freight_Allowance)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Repack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ListPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdditionalInformation)
                .HasMaxLength(300);

            this.Property(t => t.MinimumInvoice)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StdPack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AltPack)
                .HasMaxLength(50);

            this.Property(t => t.CPCName)
                .HasMaxLength(50);

            this.Property(t => t.CPCCity)
                .HasMaxLength(50);

            this.Property(t => t.CPCState)
                .HasMaxLength(50);

            this.Property(t => t.CPCCountry)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tmp_pda_master2");
            this.Property(t => t.ApprovedBy).HasColumnName("ApprovedBy");
            this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.CurrentPrice).HasColumnName("CurrentPrice");
            this.Property(t => t.NewRequested_Price).HasColumnName("NewRequested Price");
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.ExpirationDate).HasColumnName("ExpirationDate");
            this.Property(t => t.FreightTerms).HasColumnName("FreightTerms");
            this.Property(t => t.Competitor).HasColumnName("Competitor");
            this.Property(t => t.CompetitiveProduct).HasColumnName("CompetitiveProduct");
            this.Property(t => t.CompetitivePrice).HasColumnName("CompetitivePrice");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.ShipTo).HasColumnName("ShipTo");
            this.Property(t => t.ShipToName).HasColumnName("ShipToName");
            this.Property(t => t.ShipToCity).HasColumnName("ShipToCity");
            this.Property(t => t.ShipToState).HasColumnName("ShipToState");
            this.Property(t => t.ShipToCountry).HasColumnName("ShipToCountry");
            this.Property(t => t.BillTo).HasColumnName("BillTo");
            this.Property(t => t.BillToName).HasColumnName("BillToName");
            this.Property(t => t.BillToCity).HasColumnName("BillToCity");
            this.Property(t => t.BillToState).HasColumnName("BillToState");
            this.Property(t => t.BillToCountry).HasColumnName("BillToCountry");
            this.Property(t => t.Entity).HasColumnName("Entity");
            this.Property(t => t.Break_Pallet).HasColumnName("Break_Pallet");
            this.Property(t => t.Freight_Allowance).HasColumnName("Freight_Allowance");
            this.Property(t => t.Repack).HasColumnName("Repack");
            this.Property(t => t.ListPrice).HasColumnName("ListPrice");
            this.Property(t => t.AdditionalInformation).HasColumnName("AdditionalInformation");
            this.Property(t => t.MinimumInvoice).HasColumnName("MinimumInvoice");
            this.Property(t => t.StdPack).HasColumnName("StdPack");
            this.Property(t => t.AltPack).HasColumnName("AltPack");
            this.Property(t => t.CPCName).HasColumnName("CPCName");
            this.Property(t => t.CPCCity).HasColumnName("CPCCity");
            this.Property(t => t.CPCState).HasColumnName("CPCState");
            this.Property(t => t.CPCCountry).HasColumnName("CPCCountry");
        }
    }
}
