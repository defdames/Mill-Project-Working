using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ChannelPartner_DropShipbilltoMap : EntityTypeConfiguration<ChannelPartner_DropShipbillto>
    {
        public ChannelPartner_DropShipbilltoMap()
        {
            // Primary Key
            this.HasKey(t => t.Billto);

            // Properties
            this.Property(t => t.Billto)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ChannelPartner_DropShipbillto");
            this.Property(t => t.Billto).HasColumnName("Billto");
        }
    }
}
