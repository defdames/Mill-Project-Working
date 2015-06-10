using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAhdrMap : EntityTypeConfiguration<PDAhdr>
    {
        public PDAhdrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RequestNo, t.RequestedBy, t.RequestDate, t.Market, t.Customer, t.ShipTo, t.BillTo });

            // Properties
            this.Property(t => t.RequestNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RequestedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RebateProgram)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTerms)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FreightTerms)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipToName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToName)
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

            this.Property(t => t.BillToCity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToState)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillToCountry)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MultiNational)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FreightPayment)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerPhone)
                .HasMaxLength(50);

            this.Property(t => t.CustomerEmail)
                .HasMaxLength(50);

            this.Property(t => t.Entity)
                .IsRequired()
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
            this.ToTable("PDAhdr");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.RequestedBy).HasColumnName("RequestedBy");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.RebateProgram).HasColumnName("RebateProgram");
            this.Property(t => t.PaymentTerms).HasColumnName("PaymentTerms");
            this.Property(t => t.FreightTerms).HasColumnName("FreightTerms");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.ShipTo).HasColumnName("ShipTo");
            this.Property(t => t.ShipToName).HasColumnName("ShipToName");
            this.Property(t => t.BillTo).HasColumnName("BillTo");
            this.Property(t => t.BillToName).HasColumnName("BillToName");
            this.Property(t => t.ShipToCity).HasColumnName("ShipToCity");
            this.Property(t => t.ShipToState).HasColumnName("ShipToState");
            this.Property(t => t.ShipToCountry).HasColumnName("ShipToCountry");
            this.Property(t => t.BillToCity).HasColumnName("BillToCity");
            this.Property(t => t.BillToState).HasColumnName("BillToState");
            this.Property(t => t.BillToCountry).HasColumnName("BillToCountry");
            this.Property(t => t.MultiNational).HasColumnName("MultiNational");
            this.Property(t => t.Zone).HasColumnName("Zone");
            this.Property(t => t.FreightPayment).HasColumnName("FreightPayment");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactTitle).HasColumnName("ContactTitle");
            this.Property(t => t.CustomerPhone).HasColumnName("CustomerPhone");
            this.Property(t => t.CustomerEmail).HasColumnName("CustomerEmail");
            this.Property(t => t.Entity).HasColumnName("Entity");
            this.Property(t => t.CPCName).HasColumnName("CPCName");
            this.Property(t => t.CPCCity).HasColumnName("CPCCity");
            this.Property(t => t.CPCState).HasColumnName("CPCState");
            this.Property(t => t.CPCCountry).HasColumnName("CPCCountry");
        }
    }
}
