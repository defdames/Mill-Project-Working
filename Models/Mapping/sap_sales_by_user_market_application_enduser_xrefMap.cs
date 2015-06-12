using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sap_sales_by_user_market_application_enduser_xrefMap : EntityTypeConfiguration<sap_sales_by_user_market_application_enduser_xref>
    {
        public sap_sales_by_user_market_application_enduser_xrefMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.Shipto, t.Product });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Shipto)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Market)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("sap_sales_by_user_market_application_enduser_xref");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Shipto).HasColumnName("Shipto");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Market).HasColumnName("Market");
        }
    }
}
