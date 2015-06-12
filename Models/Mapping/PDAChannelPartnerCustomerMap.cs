using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAChannelPartnerCustomerMap : EntityTypeConfiguration<PDAChannelPartnerCustomer>
    {
        public PDAChannelPartnerCustomerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.entity, t.customer, t.billto, t.shipto, t.CPCName });

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

            this.Property(t => t.shipto)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CPCName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PDAChannelPartnerCustomer");
            this.Property(t => t.entity).HasColumnName("entity");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.billto).HasColumnName("billto");
            this.Property(t => t.shipto).HasColumnName("shipto");
            this.Property(t => t.CPCName).HasColumnName("CPCName");
        }
    }
}
