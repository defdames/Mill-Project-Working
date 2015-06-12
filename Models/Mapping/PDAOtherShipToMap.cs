using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAOtherShipToMap : EntityTypeConfiguration<PDAOtherShipTo>
    {
        public PDAOtherShipToMap()
        {
            // Primary Key
            this.HasKey(t => new { t.entity, t.customer, t.billto, t.othershipto });

            // Properties
            this.Property(t => t.entity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.customer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.billto)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.othershipto)
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

            // Table & Column Mappings
            this.ToTable("PDAOtherShipTo");
            this.Property(t => t.entity).HasColumnName("entity");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.billto).HasColumnName("billto");
            this.Property(t => t.othershipto).HasColumnName("othershipto");
            this.Property(t => t.ShipToName).HasColumnName("ShipToName");
            this.Property(t => t.ShipToCity).HasColumnName("ShipToCity");
            this.Property(t => t.ShipToState).HasColumnName("ShipToState");
            this.Property(t => t.ShipToCountry).HasColumnName("ShipToCountry");
        }
    }
}
